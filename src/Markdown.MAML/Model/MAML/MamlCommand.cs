﻿using System.Collections.Generic;

namespace Markdown.MAML.Model.MAML
{
    public class MamlCommand
    {
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }

        public List<MamlInputOutput> Inputs 
        {
            get { return _inputs; }
        }

        public List<MamlInputOutput> Outputs
        {
            get { return _outputs; }
        }

        public List<MamlParameter> Parameters 
        {
            get { return _parameters; } 
        }

        public string Notes { get; set; }

        public List<MamlExample> Examples
        {
            get { return _examples; }
        } 

        public List<MamlLinks> Links
        {
            get { return _links; }
        }

        private List<MamlParameter> _parameters = new List<MamlParameter>();

        private List<MamlInputOutput> _outputs = new List<MamlInputOutput>();

        private List<MamlInputOutput> _inputs = new List<MamlInputOutput>();

        private List<MamlExample> _examples = new List<MamlExample>();

        private List<MamlLinks> _links = new List<MamlLinks>();
    }
}