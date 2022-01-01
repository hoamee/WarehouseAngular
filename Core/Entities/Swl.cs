

namespace Core.Entities
{
    public class Site
    {
        public string SiId { get; set; }
        public string SiName { set; get; }
        public bool SiActive { set; get; }
        public string SiNote { get; set; }
    }

    public class Warehouse
    {
        public string WhId { get; set; }
        public string WhName { set; get; }
        public bool WhActive { set; get; }
        public string WhNote { get; set; }
        public Site Site { get; set; }
        public string SiteId { get; set; }
    }

    public class Location
    {
        public string LocId { get; set; }
        public string LocName { set; get; }
        public bool LocFrammable { get; set; }
        public bool LocActive { set; get; }
        public string LocNote { get; set; }
        public double LocCap { get; set; }
        public Warehouse Warehouse { get; set; }
        public string WhId { set; get; }
    }
}