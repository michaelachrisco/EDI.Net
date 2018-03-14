using indice.Edi.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace indice.Edi.Tests.Models
{
    public class Implementation_Acknowledgment_999
    {
        #region ISA and IEA
        [EdiValue("X(2)", Path = "ISA/0", Description = "ISA01 - Authorization Information Qualifier")]
        public string AuthorizationInformationQualifier { get; set; }

        [EdiValue("X(10)", Path = "ISA/1", Description = "ISA02 - Authorization Information")]
        public string AuthorizationInformation { get; set; }

        [EdiValue("X(2)", Path = "ISA/2", Description = "ISA03 - Security Information Qualifier")]
        public string Security_Information_Qualifier { get; set; }

        [EdiValue("X(10)", Path = "ISA/3", Description = "ISA04 - Security Information")]
        public string Security_Information { get; set; }

        [EdiValue("X(2)", Path = "ISA/4", Description = "ISA05 - Interchange ID Qualifier")]
        public string ID_Qualifier { get; set; }

        [EdiValue("X(15)", Path = "ISA/5", Description = "ISA06 - Interchange Sender ID")]
        public string Sender_ID { get; set; }

        [EdiValue("X(2)", Path = "ISA/6", Description = "ISA07 - Interchange ID Qualifier")]
        public string ID_Qualifier2 { get; set; }

        [EdiValue("X(15)", Path = "ISA/7", Description = "ISA08 - Interchange Receiver ID")]
        public string Receiver_ID { get; set; }

        [EdiValue("X(6)", Path = "ISA/8", Format = "yyMMdd", Description = "I09 - Interchange Date")]
        public string InterchangeDate { get; set; }

        [EdiValue("X(4)", Path = "ISA/9", Format = "HHmm", Description = "I10 - Interchange Time")]
        public string InterchangeTime { get; set; }

        [EdiValue("X(1)", Path = "ISA/10", Description = "ISA11 - Interchange Control Standards ID")]
        public string Control_Standards_ID { get; set; }

        [EdiValue("X(5)", Path = "ISA/11", Description = "ISA12 - Interchange Control Version Num")]
        public string ControlVersion { get; set; }

        [EdiValue("X(9)", Path = "ISA/12", Description = "ISA13 - Interchange Control Number")]
        public string ControlNumber { get; set; }

        [EdiValue("X(1)", Path = "ISA/13", Description = "ISA14 - Acknowledgement Requested")]
        public string AcknowledgementRequested { get; set; }

        [EdiValue("X(1)", Path = "ISA/14", Description = "ISA15 - Usage Indicator")]
        public string Usage_Indicator { get; set; }

        [EdiValue("X(1)", Path = "ISA/15", Description = "ISA16 - Component Element Separator")]
        public char? Component_Element_Separator { get; set; }

        [EdiValue("X(1)", Path = "IEA/0", Description = "IEA01 - Num of Included Functional Grps")]
        public string GroupsCount { get; set; }

        [EdiValue("X(9)", Path = "IEA/1", Description = "IEA02 - Interchange Control Number")]
        public string TrailerControlNumber { get; set; }

        #endregion
    }
}
