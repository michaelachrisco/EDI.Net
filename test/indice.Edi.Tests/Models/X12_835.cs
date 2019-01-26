﻿using System;
using System.Collections.Generic;
using System.Text;
using indice.Edi.Serialization;

namespace indice.Edi.Tests.Models
{
    public class HealthCareClaimPaymentAdvice_835
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

        [EdiValue("X(1)", Path = "IEA/0", Description = "IEA01 - Num of Included Functional Groups")]
        public string GroupsCount { get; set; }

        [EdiValue("X(9)", Path = "IEA/1", Description = "IEA02 - Interchange Control Number")]
        public string TrailerControlNumber { get; set; }

        #endregion

        public List<HealthCareClaimPaymentAdvice_835.FunctionalGroup> Groups { get; set; }


        [EdiGroup]
        public class FunctionalGroup
        {

            [EdiValue("X(2)", Path = "GS/0", Description = "GS01 - Functional Identifier Code")]
            public string FunctionalIdentifierCode { get; set; }

            [EdiValue("X(15)", Path = "GS/1", Description = "GS02 - Application Sender's Code")]
            public string ApplicationSenderCode { get; set; }

            [EdiValue("X(15)", Path = "GS/2", Description = "GS03 - Application Receiver ID")]
            public string ApplicationReceiverCode { get; set; }

            [EdiValue("X(8)", Path = "GS/3", Description = "GS04 - Date")]
            public string Date { get; set; }

            [EdiValue("X(8)", Path = "GS/4", Description = "GS05 - Time")]
            public string Time { get; set; }

            [EdiValue("X(9)", Path = "GS/5", Description = "GS06 - Group Control Number")]
            public string GroupControlNumber { get; set; }

            [EdiValue("X(2)", Path = "GS/6", Description = "GS07 Responsible Agency Code")]
            public string AgencyCode { get; set; }

            [EdiValue("X(2)", Path = "GS/7", Description = "GS08 Version / Release / Industry Identifier Code")]
            public string Version { get; set; }

            public HealthCareClaimPaymentAdvice_835.Headers Headers { get; set; }

            [EdiValue("X(1)", Path = "GE/0", Description = "97 Number of Transaction Sets Included")]
            public string TransactionsCount { get; set; }

            [EdiValue("X(9)", Path = "GE/1", Description = "28 Group Control Number")]
            public string GroupTrailerControlNumber { get; set; }
        }

        [EdiMessage]
        public class Headers
        {
            #region Header Trailer

            [EdiValue("X(3)", Path = "ST/0", Description = "ST01 - Transaction set ID code")]
            public string TransactionSetCode { get; set; }

            [EdiValue("X(9)", Path = "ST/1", Description = "ST02 - Transaction set control number")]
            public string TransactionSetControlNumber { get; set; }

            [EdiValue("X(35)", Path = "ST/2", Description = "ST03 - Transaction set control number")]
            public string ImplementationConventionReference { get; set; }

            //BPR: Financial Information
            [EdiValue("X(2)", Path = "BPR/0", Description = "BPR01 - Transaction Handling Code")]
            public string TransactionHandlingCode { get; set; }

            [EdiValue("X(18)", Path = "BPR/1", Description = "BPR02 - Monetary Amount")]
            public string MonetaryAmount { get; set; }

            [EdiValue("X(1)", Path = "BPR/2", Description = "BPR03 - Credit/Debit Flag")]
            public char? CreditDebitFlag { get; set; }

            [EdiValue("X(3)", Path = "BPR/3", Description = "BPR04 - Payment Method Code")]
            public string PaymentMethodCode { get; set; }

            [EdiValue("X(10)", Path = "BPR/4", Description = "BPR05 - Payment Format Code")]
            public string PaymentFormatCode { get; set; }

            [EdiValue("X(2)", Path = "BPR/5", Description = "BPR06 - (DFI) ID Number Qualifier")]
            public string IDNumberQualifier { get; set; }

            [EdiValue("X(12)", Path = "BPR/6", Description = "BPR07 - (DFI) Identification Number")]
            public string IdentificationNumber { get; set; }

            [EdiValue("X(3)", Path = "BPR/7", Description = "BPR08 - Account Number Qualifier")]
            public string AccountNumberQualifier { get; set; }

            [EdiValue("X(35)", Path = "BPR/8", Description = "BPR09 - Sender Bank Account Number")]
            public string SenderBankAccountNumber { get; set; }

            [EdiValue("X(10)", Path = "BPR/9", Description = "BPR10 - Originating Company Identifier")]
            public string OriginatingCompanyIdentifier { get; set; }

            [EdiValue("X(9)", Path = "BPR/10", Description = "BPR11 - Originating Company Supplemental Code")]
            public string OriginatingCompanySupplementalCode { get; set; }

            [EdiValue("X(2)", Path = "BPR/11", Description = "BPR12 - DFI Identification Number Qualifier")]
            public string DFIIdentificationNumberQualifier { get; set; }

            [EdiValue("X(12)", Path = "BPR/12", Description = "BPR13 - Receiver or Provider Bank ID Number")]
            public string ReceiverOrProviderBankIDNumber { get; set; }

            [EdiValue("X(3)", Path = "BPR/13", Description = "BPR14 - Account Number Qualifier")]
            public string ReceiverOrProviderAccountNumberQualifier { get; set; }

            [EdiValue("X(35)", Path = "BPR/14", Description = "BPR15 - Receiver or Provider Account Number")]
            public string ReceiverOrProviderAccountNumber { get; set; }

            [EdiValue("9(8)", Path = "BPR/15", Description = "BPR16 - Check Issue or EFT Effective Date")]
            public DateTime CheckIssuanceDate { get; set; }

            //TODO: Separate out 834 and 835 specific basic segments.
            //They share about 70% of the base objects, but may need to separate out each.

            /*
            [EdiValue("X(50)", Path = "BGN/1", Description = "BGN02 - Transaction Set Reference Number")]
            public string TransactionSetReferenceNumber { get; set; }

            [EdiValue("9(6)", Path = "BGN/2", Format = "yyyyMMdd", Description = "BGN03 - Interchange Date")]
            [EdiValue("9(4)", Path = "BGN/3", Format = "HHmm", Description = "BGN04 - Interchange Time")]
            public DateTime TransactionSetCreationDate { get; set; }

            [EdiValue("X(2)", Path = "BGN/4", Description = "BGN05 - Time Code")]
            public string TimeCode { get; set; }

            [EdiValue("X(50)", Path = "BGN/5", Description = "BGN06 - Reference Identification")]
            public string ReferenceIdentification { get; set; }

            [EdiValue("X(2)", Path = "BGN/6", Description = "BGN07 - Transaction Type Code")]
            public string TransactionTypeCode { get; set; }

            [EdiValue("X(2)", Path = "BGN/7", Description = "BGN08 - Action Code")]
            public string ActionCode { get; set; }

            public BenefitEnrollmentAndMaintenance_834.REF TransactionSetPolicyNumber { get; set; }

            public BenefitEnrollmentAndMaintenance_834.DTP FileEffectiveDate { get; set; }

            public List<BenefitEnrollmentAndMaintenance_834.QTY> TransactionSetControlTotals { get; set; }

            //Loop 1000A
            //Segment N1 Sponsor Name
            [EdiCondition("P5", Path = "N1/0/0")]
            public BenefitEnrollmentAndMaintenance_834.N1 SponsorName { get; set; }

            //Loop 1000B
            //Segment N1 Payer
            [EdiCondition("IN", Path = "N1/0/0")]
            public BenefitEnrollmentAndMaintenance_834.N1 Payer { get; set; }

            //Loop 1000C
            //Segment N1 Broker
            [EdiCondition("BO", Path = "N1/0/0")]
            public BenefitEnrollmentAndMaintenance_834.N1 Broker { get; set; }

            //Loop 1000C
            //Segment N1 Third Party Administrator
            [EdiCondition("TV", Path = "N1/0/0")]
            public BenefitEnrollmentAndMaintenance_834.N1 ThirdPartyAdministrator { get; set; }

            public List<BenefitEnrollmentAndMaintenance_834.MemberDetail> MemberDetails { get; set; }

            [EdiValue(Path = "SE/0", Description = "SE01 - Number of included segments")]
            public int SegmentCounts { get; set; }

            [EdiValue("X(9)", Path = "SE/1", Description = "SE02 - Transaction set control number (same as ST02)")]
            public string TrailerTransactionSetControlNumber { get; set; }
            */
            #endregion
        }
        /*
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

            [EdiValue("X(1)", Path = "INS/9", Description = "INS10 - Response Code (Handicap Indicator)")]
            public string HandicapIndicator { get; set; }

            [EdiValue("X(3)", Path = "INS/10", Description = "INS11 - Date Time Period Format Qualifier")]
            public string DateTimePeriodFormatQualifier { get; set; }

            [EdiValue("X(35)", Path = "INS/11", Description = "INS12 - Date Time Period")]
            public string DateTimePeriod { get; set; }

            [EdiValue("X(35)", Path = "INS/12", Description = "INS13 - Confidentiality Code")]
            public string ConfidentialityCode { get; set; }

            [EdiValue("X(30)", Path = "INS/13", Description = "INS14 - City Name", Mandatory = false)]
            public string CityName { get; set; }

            [EdiValue("X(30)", Path = "INS/14", Description = "INS15 - State or Province Code", Mandatory = false)]
            public string StateProvinceCode { get; set; }

            [EdiValue("X(3)", Path = "INS/15", Description = "INS16 - Country Code", Mandatory = false)]
            public string CountryCode { get; set; }

            [EdiValue("X(9)", Path = "INS/16", Description = "INS17 - Number", Mandatory = false)]
            public string Number { get; set; }

            public List<BenefitEnrollmentAndMaintenance_834.REF> MemberReferences { get; set; }

            public List<BenefitEnrollmentAndMaintenance_834.DTP> MemberLevelDates { get; set; }

            public BenefitEnrollmentAndMaintenance_834.NM1 MemberName { get; set; }

            public BenefitEnrollmentAndMaintenance_834.PER MemberCommunicationsNumbers { get; set; }

            public BenefitEnrollmentAndMaintenance_834.N3 MemberResidenceStreetAddress { get; set; }

            public BenefitEnrollmentAndMaintenance_834.N4 MemberCityStateZIPCode { get; set; }

            public BenefitEnrollmentAndMaintenance_834.DMG MemberDemographics { get; set; }

            public BenefitEnrollmentAndMaintenance_834.NM1 MemberMailingAddress { get; set; }

            public BenefitEnrollmentAndMaintenance_834.N3 MemberMailStreetAddress { get; set; }

            public BenefitEnrollmentAndMaintenance_834.N4 MemberMailCityStateZIPCode { get; set; }

            //public List<DTP> DisabilityEligibilityDates { get; set; }

            //Loop 2300
            public List<BenefitEnrollmentAndMaintenance_834.Benefit> Benefits { get; set; }
        }

        [EdiSegment, EdiPath("HD")]
        public class Benefit
        {
            public BenefitEnrollmentAndMaintenance_834.HD HealthCoverage { get; set; }

            public List<BenefitEnrollmentAndMaintenance_834.DTP> HealthCoverageDates { get; set; }

            public List<BenefitEnrollmentAndMaintenance_834.REF> HealthCoveragePolicyNumbers { get; set; }
        }

        [EdiSegment, EdiPath("REF")]
        public class REF
        {
            [EdiValue("X(3)", Path = "REF/0", Description = "REF01 - Reference Identification Qualifier")]
            public string ReferenceIdentificationQualifier { get; set; }

            [EdiValue("X(50)", Path = "REF/1", Description = "REF02 - Reference Identification")]
            public string ReferenceIdentification { get; set; }

            [EdiValue("X(35)", Path = "REF/2", Description = "REF03 - Date Time Period", Mandatory = false)]
            public string DateTimePeriod { get; set; }
        }

        [EdiSegment, EdiPath("DTP")]
        public class DTP
        {
            [EdiValue("X(3)", Path = "DTP/0", Description = "DTP01 - Date/Time Qualifier")]
            public string DateTimeQualifier { get; set; }

            [EdiValue("X(3)", Path = "DTP/1", Description = "DTP02 - Date Time Period Format Qualifier")]
            public string DateTimePeriodFormatQualifier { get; set; }

            [EdiValue("X(35)", Path = "DTP/2", Description = "DTP03 - Date Time Period", Mandatory = false)]
            public string DateTimePeriod { get; set; }
        }

        [EdiSegment, EdiPath("QTY")]
        public class QTY
        {
            [EdiValue("X(2)", Path = "QTY/0", Description = "QTY01 - Quantity Qualifier")]
            public string QuantityQualifier { get; set; }

            [EdiValue("X(15)", Path = "QTY/1", Description = "QTY02 - Date Time Period Format Qualifier")]
            public string Quantity { get; set; }
        }

        [EdiSegment, EdiPath("NM1")]
        public class NM1
        {
            [EdiValue("X(3)", Path = "NM1/0", Description = "NM101 - Entity Identifier Code")]
            public string EntityIdentifierCode { get; set; }

            [EdiValue("X(1)", Path = "NM1/1", Description = "NM102 - Entity Type Qualifier")]
            public string EntityTypeQualifier { get; set; }

            [EdiValue("X(60)", Path = "NM1/2", Description = "NM103 - Name Last or Organization Name")]
            public string NameLastOrOrganizationName { get; set; }

            [EdiValue("X(35)", Path = "NM1/3", Description = "NM104 - Name First")]
            public string NameFirst { get; set; }

            [EdiValue("X(25)", Path = "NM1/4", Description = "NM105 - Name Middle", Mandatory = false)]
            public string NameMiddle { get; set; }

            [EdiValue("X(10)", Path = "NM1/5", Description = "NM106 - Name Prefix", Mandatory = false)]
            public string NamePrefix { get; set; }

            [EdiValue("X(10)", Path = "NM1/6", Description = "NM107 - Name Suffix", Mandatory = false)]
            public string NameSuffix { get; set; }

            [EdiValue("X(2)", Path = "NM1/7", Description = "NM108 - Identification Code Qualifier")]
            public string IdentificationCodeQualifier { get; set; }

            [EdiValue("X(80)", Path = "NM1/8", Description = "NM109 - Identification Code")]
            public string IdentificationCode { get; set; }
        }

        [EdiSegment, EdiPath("PER")]
        public class PER
        {
            [EdiValue("X(2)", Path = "PER/0", Description = "PER01 - Contact Function Code")]
            public string ContactFunctionCode { get; set; }

            [EdiValue("X(60)", Path = "PER/1", Description = "PER02 - Name")]
            public string Name { get; set; }

            [EdiValue("X(2)", Path = "PER/2", Description = "PER03 - Communication Number Qualifier 1")]
            public string CommunicationNumberQualifier { get; set; }

            [EdiValue("X(256)", Path = "PER/3", Description = "PER04 - Communication Number 1")]
            public string CommunicationNumber { get; set; }

            [EdiValue("X(2)", Path = "PER/4", Description = "PER05 - Communication Number Qualifier 2")]
            public string CommunicationNumberQualifier2 { get; set; }

            [EdiValue("X(256)", Path = "PER/5", Description = "PER06 - Communication Number 2")]
            public string CommunicationNumber2 { get; set; }

            [EdiValue("X(2)", Path = "PER/6", Description = "PER07 - Communication Number Qualifier 3")]
            public string CommunicationNumberQualifier3 { get; set; }

            [EdiValue("X(256)", Path = "PER/7", Description = "PER08 - Communication Number 3")]
            public string CommunicationNumber3 { get; set; }
        }

        [EdiSegment, EdiPath("N3")]
        public class N3
        {
            [EdiValue("X(55)", Path = "N3/0", Description = "N301 - Address Information")]
            public string AddressInformation { get; set; }

            [EdiValue("X(55)", Path = "N3/1", Description = "N302 - Address Information 2")]
            public string AddressInformation2 { get; set; }
        }

        [EdiSegment, EdiPath("N4")]
        public class N4
        {
            [EdiValue("X(30)", Path = "N4/0", Description = "N401 - City Name")]
            public string CityName { get; set; }

            [EdiValue("X(2)", Path = "N4/1", Description = "N402 - State or Province Code")]
            public string StateOrProvinceCode { get; set; }

            [EdiValue("X(15)", Path = "N4/2", Description = "N403 - Postal Code")]
            public string PostalCode { get; set; }

            [EdiValue("X(3)", Path = "N4/3", Description = "N404 - Country Code")]
            public string CountryCode { get; set; }

            [EdiValue("X(2)", Path = "N4/4", Description = "N405 - Location Qualifier")]
            public string LocationQualifier { get; set; }

            [EdiValue("X(30)", Path = "N4/5", Description = "N406 - Location Identifier")]
            public string LocationIdentifier { get; set; }

            [EdiValue("X(3)", Path = "N4/6", Description = "N407 - Country Subdivision Code")]
            public string CountrySubdivisionCode { get; set; }
        }

        [EdiSegment, EdiPath("DMG")]
        public class DMG
        {
            [EdiValue("X(3)", Path = "DMG/0", Description = "DMG01 - Date Time Period Format Qualifier")]
            public string DateTimePeriodFormatQualifier { get; set; }

            [EdiValue("X(35)", Path = "DMG/1", Description = "DMG02 - Date Time Period")]
            public string DateTimePeriod { get; set; }

            [EdiValue("X(1)", Path = "DMG/2", Description = "DMG03 - Gender Code")]
            public string GenderCode { get; set; }

            [EdiValue("X(1)", Path = "DMG/3", Description = "DMG04 - Marital Status Code")]
            public string MaritalStatusCode { get; set; }

            [EdiValue("X(10)", Path = "DMG/4", Description = "DMG05 - Composite Race or Ethnicity Information")]
            public string CompositeRace { get; set; }

            [EdiValue("X(2)", Path = "DMG/5", Description = "DMG06 - Citizenship Status Code")]
            public string CitizenshipStatusCode { get; set; }
        }


        [EdiSegment, EdiPath("HD")]
        public class HD
        {
            [EdiValue("X(3)", Path = "HD/0", Description = "HD01 - Maintenance Type Code")]
            public string MaintenanceTypeCode { get; set; }

            [EdiValue("X(3)", Path = "HD/1", Description = "HD02 - Maintenance Reason Code")]
            public string MaintenanceReasonCode { get; set; }

            [EdiValue("X(3)", Path = "HD/2", Description = "HD03 - Insurance Line Code")]
            public string InsuranceLineCode { get; set; }

            [EdiValue("X(50)", Path = "HD/3", Description = "HD04 - Plan Coverage Description")]
            public string PlanCoverageDescription { get; set; }

            [EdiValue("X(3)", Path = "HD/4", Description = "HD05 - Coverage Level Code")]
            public string CoverageLevelCode { get; set; }
        }
        */
    }

}
