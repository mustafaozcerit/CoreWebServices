using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class XpoState
    {
        public XpoState()
        {
            XpoStateAppearance = new HashSet<XpoStateAppearance>();
            XpoStateMachine = new HashSet<XpoStateMachine>();
            XpoTransitionSourceStateNavigation = new HashSet<XpoTransition>();
            XpoTransitionTargetStateNavigation = new HashSet<XpoTransition>();
        }

        public Guid Oid { get; set; }
        public string Caption { get; set; }
        public Guid? StateMachine { get; set; }
        public string MarkerValue { get; set; }
        public string TargetObjectCriteria { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual XpoStateMachine StateMachineNavigation { get; set; }
        public virtual ICollection<XpoStateAppearance> XpoStateAppearance { get; set; }
        public virtual ICollection<XpoStateMachine> XpoStateMachine { get; set; }
        public virtual ICollection<XpoTransition> XpoTransitionSourceStateNavigation { get; set; }
        public virtual ICollection<XpoTransition> XpoTransitionTargetStateNavigation { get; set; }
    }
}
