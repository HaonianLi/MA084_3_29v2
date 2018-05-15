namespace CharityStartAtHome.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Blood")]
    public partial class Blood
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Center { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public string Service { get; set; }

        public string AdditionNote { get; set; }

        public string Openhour { get; set; }

        public byte[] Findme { get; set; }
    }
}
