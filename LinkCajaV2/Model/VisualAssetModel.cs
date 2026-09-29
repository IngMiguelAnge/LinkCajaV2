using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class VisualAssetModel
    {
        public int Id { get; set; }

        public string AssetKey { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string Extension { get; set; }

        public long? FileSize { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public bool Status { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastModification { get; set; }
    }
}
