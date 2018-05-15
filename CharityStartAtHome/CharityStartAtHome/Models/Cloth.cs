namespace CharityStartAtHome.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cloth")]
    public partial class Cloth
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Service { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public string OpenTime { get; set; }

        public string State { get; set; }

        [StringLength(50)]
        public string Suburb { get; set; }

        public string Address { get; set; }

        public short Postcode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public string Findme { get; set; }
    }
}
