using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleProject
{
    public class ProjectModel
    {
        public int Pid { get; set; }
        public string PName { get; set; }
        public string PStart { get; set; }
        public string PEnd { get; set; }
        public string PPlanStart { get; set; }
        public string PPlanEnd { get; set; }
        public string PClass { get; set; }
        public string PLink { get; set; }
        public int PMile { get; set; }
        public string PRes { get; set; }
        public int PComp { get; set; }
        public int PGroup  { get; set; }
        public int PParent { get; set; }
        public int POpen { get; set; }
        public string PDepend { get; set; }
        public string PCaption { get; set; }
        public string PNotes { get; set; }
    }
}