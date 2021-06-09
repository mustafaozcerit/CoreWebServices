using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class XpobjectType
    {
        public XpobjectType()
        {
            MediaDataObject = new HashSet<MediaDataObject>();
            Party = new HashSet<Party>();
            PermissionPolicyRole = new HashSet<PermissionPolicyRole>();
            PermissionPolicyUser = new HashSet<PermissionPolicyUser>();
            RoleBase = new HashSet<RoleBase>();
            SecuritySystemRole = new HashSet<SecuritySystemRole>();
            SecuritySystemTypePermissionsObject = new HashSet<SecuritySystemTypePermissionsObject>();
            SecuritySystemUser = new HashSet<SecuritySystemUser>();
            XpweakReferenceObjectTypeNavigation = new HashSet<XpweakReference>();
            XpweakReferenceTargetTypeNavigation = new HashSet<XpweakReference>();
        }

        public int Oid { get; set; }
        public string TypeName { get; set; }
        public string AssemblyName { get; set; }

        public virtual ICollection<MediaDataObject> MediaDataObject { get; set; }
        public virtual ICollection<Party> Party { get; set; }
        public virtual ICollection<PermissionPolicyRole> PermissionPolicyRole { get; set; }
        public virtual ICollection<PermissionPolicyUser> PermissionPolicyUser { get; set; }
        public virtual ICollection<RoleBase> RoleBase { get; set; }
        public virtual ICollection<SecuritySystemRole> SecuritySystemRole { get; set; }
        public virtual ICollection<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObject { get; set; }
        public virtual ICollection<SecuritySystemUser> SecuritySystemUser { get; set; }
        public virtual ICollection<XpweakReference> XpweakReferenceObjectTypeNavigation { get; set; }
        public virtual ICollection<XpweakReference> XpweakReferenceTargetTypeNavigation { get; set; }
    }
}
