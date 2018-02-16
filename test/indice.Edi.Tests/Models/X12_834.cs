using indice.Edi.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace indice.Edi.Tests.Models
{
    /// <summary>
    /// Benefit Enrollment and Maintenance 834
    /// </summary>
    public class BenefitEnrollmentAndMaintenance_834 {
        #region ISA and IEA
        [EdiValue("9(2)", Path = "ISA/0", Description = "ISA01 - Authorization Information Qualifier")]
        public int AuthorizationInformationQualifier { get; set; }

        [EdiValue("X(10)", Path = "ISA/1", Description = "ISA02 - Authorization Information")]
        public string AuthorizationInformation { get; set; }

        [EdiValue("9(2)", Path = "ISA/2", Description = "ISA03 - Security Information Qualifier")]
        public string Security_Information_Qualifier { get; set; }

        [EdiValue("X(10)", Path = "ISA/3", Description = "ISA04 - Security Information")]
        public string Security_Information { get; set; }

        [EdiValue("9(2)", Path = "ISA/4", Description = "ISA05 - Interchange ID Qualifier")]
        public string ID_Qualifier { get; set; }

        [EdiValue("X(15)", Path = "ISA/5", Description = "ISA06 - Interchange Sender ID")]
        public string Sender_ID { get; set; }

        [EdiValue("9(2)", Path = "ISA/6", Description = "ISA07 - Interchange ID Qualifier")]
        public string ID_Qualifier2 { get; set; }

        [EdiValue("X(15)", Path = "ISA/7", Description = "ISA08 - Interchange Receiver ID")]
        public string Receiver_ID { get; set; }

        [EdiValue("9(6)", Path = "ISA/8", Format = "yyMMdd", Description = "I09 - Interchange Date")]
        [EdiValue("9(4)", Path = "ISA/9", Format = "HHmm", Description = "I10 - Interchange Time")]
        public DateTime Date { get; set; }

        [EdiValue("X(1)", Path = "ISA/10", Description = "ISA11 - Interchange Control Standards ID")]
        public string Control_Standards_ID { get; set; }

        [EdiValue("9(5)", Path = "ISA/11", Description = "ISA12 - Interchange Control Version Num")]
        public int ControlVersion { get; set; }

        [EdiValue("9(9)", Path = "ISA/12", Description = "ISA13 - Interchange Control Number")]
        public int ControlNumber { get; set; }

        [EdiValue("9(1)", Path = "ISA/13", Description = "ISA14 - Acknowledgement Requested")]
        public bool? AcknowledgementRequested { get; set; }

        [EdiValue("X(1)", Path = "ISA/14", Description = "ISA15 - Usage Indicator")]
        public string Usage_Indicator { get; set; }

        [EdiValue("X(1)", Path = "ISA/15", Description = "ISA16 - Component Element Separator")]
        public char? Component_Element_Separator { get; set; }

        [EdiValue("9(1)", Path = "IEA/0", Description = "IEA01 - Num of Included Functional Grps")]
        public int GroupsCount { get; set; }

        [EdiValue("9(9)", Path = "IEA/1", Description = "IEA02 - Interchange Control Number")]
        public int TrailerControlNumber { get; set; }

        #endregion

        public List<FunctionalGroup> Groups { get; set; }

        [EdiGroup]
        public class FunctionalGroup
        {

            [EdiValue("X(2)", Path = "GS/0", Description = "GS01 - Functional Identifier Code")]
            public string FunctionalIdentifierCode { get; set; }

            [EdiValue("X(15)", Path = "GS/1", Description = "GS02 - Application Sender's Code")]
            public string ApplicationSenderCode { get; set; }

            [EdiValue("X(15)", Path = "GS/2", Description = "GS03 - Application Receiver's Code")]
            public string ApplicationReceiverCode { get; set; }

            [EdiValue("9(8)", Path = "GS/3", Format = "yyyyMMdd", Description = "GS04 - Date")]
            [EdiValue("9(4)", Path = "GS/4", Format = "HHmm", Description = "GS05 - Time")]
            public DateTime Date { get; set; }

            [EdiValue("9(9)", Path = "GS/5", Format = "HHmm", Description = "GS06 - Group Control Number")]
            public int GroupControlNumber { get; set; }

            [EdiValue("X(2)", Path = "GS/6", Format = "HHmm", Description = "GS07 Responsible Agency Code")]
            public string AgencyCode { get; set; }

            [EdiValue("X(2)", Path = "GS/7", Format = "HHmm", Description = "GS08 Version / Release / Industry Identifier Code")]
            public string Version { get; set; }

            public Heading Heading { get; set; }

            [EdiValue("9(1)", Path = "GE/0", Description = "97 Number of Transaction Sets Included")]
            public int TransactionsCount { get; set; }

            [EdiValue("9(9)", Path = "GE/1", Description = "28 Group Control Number")]
            public int GroupTrailerControlNumber { get; set; }
        }

        [EdiMessage]
        public class Heading
        {
            #region Header Trailer

            [EdiValue("X(3)", Path = "ST/0", Description = "ST01 - Transaction set ID code")]
            public string TransactionSetCode { get; set; }

            [EdiValue("X(9)", Path = "ST/1", Description = "ST02 - Transaction set control number")]
            public string TransactionSetControlNumber { get; set; }
            //Optional
            [EdiValue("X(35)", Path = "ST/2", Description = "ST02 - Transaction set control number")]
            public string ImplementationConventionReference { get; set; }

            [EdiValue("9(2)", Path = "BGN/0", Description = "BGN01 - Transaction Set Purpose Code")]
            public int TransactionSetPurposeCode { get; set; }

            [EdiValue("X(50)", Path = "BGN/1", Description = "BGN02 - Transaction Set Reference Number")]
            public string TransactionSetReferenceNumber { get; set; }

            [EdiValue("9(8)", Path = "BGN/2", Description = "BGN03 - Date")]
            public int TransactionSetCreationDate { get; set; }

            [EdiValue("9(8)", Path = "BGN/3", Description = "BGN04 - Time")]
            public int TransactionSetCreationTime { get; set; }

            [EdiValue("X(2)", Path = "BGN/4", Description = "BGN05 - Time Code")]
            public string TimeCode { get; set; }

            [EdiValue("X(50)", Path = "BGN/5", Description = "BGN06 - Reference Identification")]
            public string ReferenceIdentification { get; set; }

            [EdiValue("X(2)", Path = "BGN/6", Description = "BGN07 - Transaction Type Code")]
            public string TransactionTypeCode { get; set; }

            [EdiValue("X(2)", Path = "BGN/7", Description = "BGN08 - Action Code")]
            public string ActionCode { get; set; }

            [EdiValue(Path = "SE/0", Description = "SE01 - Number of included segments")]
            public int SegmentCounts { get; set; }

            //Loop 1000A
            //Segment N1 Sponsor Name
            [EdiCondition("P5", Path = "N1/0/0")]
            public N1 SponsorName { get; set; }

            //Loop 1000B
            //Segment N1 Payer
            [EdiCondition("IN", Path = "N1/0/0")]
            public N1 Payer { get; set; }

            //Loop 1000C
            //Segment N1 Broker
            [EdiCondition("BO", Path = "N1/0/0")]
            public N1 Broker { get; set; }

            //Loop 1000C
            //Segment N1 Third Party Administrator
            [EdiCondition("TV", Path = "N1/0/0")]
            public N1 ThirdPartyAdministrator { get; set; }

            public List<MemberDetail> MemberDetails { get; set; }

            [EdiValue("X(9)", Path = "SE/1", Description = "SE02 - Transaction set control number (same as ST02)")]
            public string TrailerTransactionSetControlNumber { get; set; }
            #endregion
        }

        [EdiSegment, EdiPath("N1")]
        public class N1
        {
            [EdiValue("X(3)", Path = "N1/0", Description = "N101 - Entity Identifier Code")]
            public string EntityIdentifierCode { get; set; }

            [EdiValue("X(60)", Path = "N1/1", Description = "N102 - Name")]
            public string Name { get; set; }

            [EdiValue("X(2)", Path = "N1/2", Description = "N103 - Identification Code Qualifier")]
            public string IdentificationCodeQualifier { get; set; }

            [EdiValue("X(80)", Path = "N1/3", Description = "N104 - Identification Code")]
            public string IdentificationCode { get; set; }
        }

        [EdiSegment, EdiPath("INS")]
        public class MemberDetail
        {
            [EdiValue("X(1)", Path = "INS/0", Description = "INS01 - Yes/No Condition or Response Code")]
            public string ResponseCode { get; set; }

            [EdiValue("X(2)", Path = "INS/1", Description = "INS02 - Individual Relationship Code")]
            public string IndividualRelationshipCode { get; set; }

            [EdiValue("X(3)", Path = "INS/2", Description = "INS03 - Maintenance Type Code")]
            public string MaintenanceTypeCode { get; set; }

            [EdiValue("X(3)", Path = "INS/3", Description = "INS04 - Maintenance Reason Code")]
            public string MaintenanceReasonCode { get; set; }

            [EdiValue("X(1)", Path = "INS/4", Description = "INS05 - Benefit Status Code")]
            public string BenefitStatusCode { get; set; }

            [EdiValue("X(1)", Path = "INS/5", Description = "INS06 - Medicare Status Code")]
            public string MedicareStatusCode { get; set; }

            [EdiValue("X(2)", Path = "INS/6", Description = "INS07 - COBRA Qualifying Event Code")]
            public string COBRAQualifyingEventCode { get; set; }

            [EdiValue("X(2)", Path = "INS/7", Description = "INS08 - Employment Status Code")]
            public string EmploymentStatusCode { get; set; }

            [EdiValue("X(1)", Path = "INS/8", Description = "INS09 - Student Status Code")]
            public string StudentStatusCode { get; set; }
            //This is supposed to be a handicap indicator but some carriers bootstrap it to convey other Y/N responses.
            [EdiValue("X(1)", Path = "INS/9", Description = "INS10 - Response Code (Handicap Indicator)")]
            public string HandicapIndicator { get; set; }

            [EdiValue("X(3)", Path = "INS/10", Description = "INS11 - Date Time Period Format Qualifier")]
            public string DateTimePeriodFormatQualifier { get; set; }

            [EdiValue("X(35)", Path = "INS/11", Description = "INS12 - Date Time Period")]
            public string DateTimePeriod { get; set; }

            [EdiValue("X(35)", Path = "INS/12", Description = "INS13 - Confidentiality Code")]
            public string ConfidentialityCode { get; set; }
            //These are usually not used but still possible...
            [EdiValue("X(30)", Path = "INS/13", Description = "INS14 - City Name", Mandatory = false)]
            public string CityName { get; set; }

            [EdiValue("X(30)", Path = "INS/14", Description = "INS15 - State or Province Code", Mandatory = false)]
            public string StateProvinceCode { get; set; }

            [EdiValue("X(3)", Path = "INS/15", Description = "INS16 - Country Code", Mandatory = false)]
            public string CountryCode { get; set; }

            [EdiValue("X(9)", Path = "INS/16", Description = "INS17 - Number", Mandatory = false)]
            public string Number { get; set; }
        }
    }
}
