using System;
using System.ComponentModel.DataAnnotations;

namespace ComicsManager.Model
{

    public class Comic
    {
        [Required] public string Title { get; set; }

        public int Cycle { get; set; }

        public string Collection { get; set; }

        public int Note { get; set; }

        public string ISBN { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Couverture { get; set; }

        public Author Scenariste { get; set; }

        public Author Dessinateur { get; set; }

        public Editor Editeur { get; set; }
    }
}