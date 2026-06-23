using LinkCajaV2.Data;
using LinkCajaV2.Model;
// Herramientas de Lucene 3.0.3
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SearchSAT
{
    private static string rutaIndice = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IndiceSat");

    // CORRECCIÓN: Usamos la ruta completa para evitar confusión con System.Version
    private const Lucene.Net.Util.Version versionLucene = Lucene.Net.Util.Version.LUCENE_30;

    public async void CrearIndiceLocal()
    {
        AppRepository obj = new AppRepository();
        List<CodeSatModel> listaClaves = new List<CodeSatModel>();
        listaClaves = await obj.GetCodeSAT(string.Empty);
        using (var directory = FSDirectory.Open(new DirectoryInfo(rutaIndice)))
        {
            using (var analyzer = new StandardAnalyzer(versionLucene))
            {
                using (var writer = new IndexWriter(directory, analyzer, true, IndexWriter.MaxFieldLength.UNLIMITED))
                {
                    foreach (var item in listaClaves)
                    {
                        var doc = new Document();

                        doc.Add(new Field("id", item.Id, Field.Store.YES, Field.Index.NOT_ANALYZED));
                        doc.Add(new Field("descripcion", item.Descripcion ?? "", Field.Store.YES, Field.Index.ANALYZED));
                        doc.Add(new Field("similares", item.Similares ?? "", Field.Store.YES, Field.Index.ANALYZED));

                        writer.AddDocument(doc);
                    }
                    writer.Commit();
                }
            }
        }
    }

    public List<CodeSatModel> BuscarSugerenciasFuzzy(string textoUsuario)
    {
        var resultados = new List<CodeSatModel>();

        if (string.IsNullOrWhiteSpace(textoUsuario)) return resultados;

        using (var directory = FSDirectory.Open(new DirectoryInfo(rutaIndice)))
        {
            if (!IndexReader.IndexExists(directory)) return resultados;

            using (var reader = IndexReader.Open(directory, true))
            using (var searcher = new IndexSearcher(reader))
            using (var analyzer = new StandardAnalyzer(versionLucene))
            {
                var queryParser = new MultiFieldQueryParser(versionLucene, new[] { "descripcion", "similares" }, analyzer);

                string[] palabras = textoUsuario.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string queryFuzzy = string.Join(" ", palabras.Select(p => p + "~"));

                try
                {
                    Query query = queryParser.Parse(queryFuzzy);
                    TopDocs hits = searcher.Search(query, 5);

                    foreach (ScoreDoc scoreDoc in hits.ScoreDocs)
                    {
                        Document doc = searcher.Doc(scoreDoc.Doc);
                        resultados.Add(new CodeSatModel
                        {
                            Id = doc.Get("id"),
                            Descripcion = doc.Get("descripcion"),
                            Similares = doc.Get("similares")
                        });
                    }
                }
                catch (ParseException)
                {
                    // Manejo de excepciones
                }
            }
        }

        return resultados;
    }
}