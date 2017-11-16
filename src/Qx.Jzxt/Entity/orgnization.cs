namespace Qx.Jzxt.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orgnization")]
    public partial class orgnization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orgnization()
        {
            org_award_instance = new HashSet<org_award_instance>();
            organization_relation = new HashSet<organization_relation>();
            organization_relation1 = new HashSet<organization_relation>();
            orgnization_position = new HashSet<orgnization_position>();
            user_orgnization = new HashSet<user_orgnization>();
        }

        [Key]
        [StringLength(50)]
        public string orgnization_id { get; set; }

        [StringLength(50)]
        public string father_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string descripe { get; set; }

        [Required]
        [StringLength(50)]
        public string orgnization_type_id { get; set; }

        [Column(TypeName = "text")]
        public string note { get; set; }

        [StringLength(50)]
        public string sub_system { get; set; }

        [StringLength(50)]
        public string organization_level_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<org_award_instance> org_award_instance { get; set; }

        public virtual organization_level organization_level { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<organization_relation> organization_relation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<organization_relation> organization_relation1 { get; set; }

        public virtual orgnization_type orgnization_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orgnization_position> orgnization_position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_orgnization> user_orgnization { get; set; }
    }
}
