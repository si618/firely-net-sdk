﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

#pragma warning disable 1591 // suppress XML summary warnings 

//
// Generated for FHIR v4.4.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An ingredient of a manufactured item or pharmaceutical product
    /// </summary>
    [FhirType("Ingredient", IsResource=true)]
    [DataContract]
    public partial class Ingredient : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Ingredient; } }
        [NotMapped]
        public override string TypeName { get { return "Ingredient"; } }
        
        [FhirType("SpecifiedSubstanceComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class SpecifiedSubstanceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SpecifiedSubstanceComponent"; } }
            
            /// <summary>
            /// Substance as a 'specified substance', implying extra substance related characteristics
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.Element _Code;
            
            /// <summary>
            /// The group of specified substance, e.g. group 1 to 4
            /// </summary>
            [FhirElement("group", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Group
            {
                get { return _Group; }
                set { _Group = value; OnPropertyChanged("Group"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Group;
            
            /// <summary>
            /// Confidentiality level of the specified substance as the ingredient
            /// </summary>
            [FhirElement("confidentiality", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Confidentiality
            {
                get { return _Confidentiality; }
                set { _Confidentiality = value; OnPropertyChanged("Confidentiality"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Confidentiality;
            
            /// <summary>
            /// Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product
            /// </summary>
            [FhirElement("strength", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Ingredient.StrengthComponent> Strength
            {
                get { if(_Strength==null) _Strength = new List<Hl7.Fhir.Model.Ingredient.StrengthComponent>(); return _Strength; }
                set { _Strength = value; OnPropertyChanged("Strength"); }
            }
            
            private List<Hl7.Fhir.Model.Ingredient.StrengthComponent> _Strength;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SpecifiedSubstanceComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.Element)Code.DeepCopy();
                    if(Group != null) dest.Group = (Hl7.Fhir.Model.CodeableConcept)Group.DeepCopy();
                    if(Confidentiality != null) dest.Confidentiality = (Hl7.Fhir.Model.CodeableConcept)Confidentiality.DeepCopy();
                    if(Strength != null) dest.Strength = new List<Hl7.Fhir.Model.Ingredient.StrengthComponent>(Strength.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SpecifiedSubstanceComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SpecifiedSubstanceComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Group, otherT.Group)) return false;
                if( !DeepComparable.Matches(Confidentiality, otherT.Confidentiality)) return false;
                if( !DeepComparable.Matches(Strength, otherT.Strength)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SpecifiedSubstanceComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Group, otherT.Group)) return false;
                if( !DeepComparable.IsExactly(Confidentiality, otherT.Confidentiality)) return false;
                if( !DeepComparable.IsExactly(Strength, otherT.Strength)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Group != null) yield return Group;
                    if (Confidentiality != null) yield return Confidentiality;
                    foreach (var elem in Strength) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Group != null) yield return new ElementValue("group", Group);
                    if (Confidentiality != null) yield return new ElementValue("confidentiality", Confidentiality);
                    foreach (var elem in Strength) { if (elem != null) yield return new ElementValue("strength", elem); }
                }
            }

            
        }
        
        
        [FhirType("StrengthComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class StrengthComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StrengthComponent"; } }
            
            /// <summary>
            /// The quantity of substance in the unit of presentation, or in the volume (or mass) of the single pharmaceutical product or manufactured item
            /// </summary>
            [FhirElement("presentation", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio Presentation
            {
                get { return _Presentation; }
                set { _Presentation = value; OnPropertyChanged("Presentation"); }
            }
            
            private Hl7.Fhir.Model.Ratio _Presentation;
            
            /// <summary>
            /// An upper limit for the quantity of substance in the unit of presentation. For use when there is a range of strengths, this is the high limit, with the presentation attribute becoming the lower limit
            /// </summary>
            [FhirElement("presentationHighLimit", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio PresentationHighLimit
            {
                get { return _PresentationHighLimit; }
                set { _PresentationHighLimit = value; OnPropertyChanged("PresentationHighLimit"); }
            }
            
            private Hl7.Fhir.Model.Ratio _PresentationHighLimit;
            
            /// <summary>
            /// A textual represention of either the whole of the presentation strength or a part of it - with the rest being in Strength.presentation as a ratio
            /// </summary>
            [FhirElement("presentationText", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PresentationTextElement
            {
                get { return _PresentationTextElement; }
                set { _PresentationTextElement = value; OnPropertyChanged("PresentationTextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PresentationTextElement;
            
            /// <summary>
            /// A textual represention of either the whole of the presentation strength or a part of it - with the rest being in Strength.presentation as a ratio
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string PresentationText
            {
                get { return PresentationTextElement != null ? PresentationTextElement.Value : null; }
                set
                {
                    if (value == null)
                        PresentationTextElement = null; 
                    else
                        PresentationTextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("PresentationText");
                }
            }
            
            /// <summary>
            /// The strength per unitary volume (or mass)
            /// </summary>
            [FhirElement("concentration", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio Concentration
            {
                get { return _Concentration; }
                set { _Concentration = value; OnPropertyChanged("Concentration"); }
            }
            
            private Hl7.Fhir.Model.Ratio _Concentration;
            
            /// <summary>
            /// An upper limit for the strength per unitary volume (or mass), for when there is a range. The concentration attribute then becomes the lower limit
            /// </summary>
            [FhirElement("concentrationHighLimit", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio ConcentrationHighLimit
            {
                get { return _ConcentrationHighLimit; }
                set { _ConcentrationHighLimit = value; OnPropertyChanged("ConcentrationHighLimit"); }
            }
            
            private Hl7.Fhir.Model.Ratio _ConcentrationHighLimit;
            
            /// <summary>
            /// A textual represention of either the whole of the concentration strength or a part of it - with the rest being in Strength.concentration as a ratio
            /// </summary>
            [FhirElement("concentrationText", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ConcentrationTextElement
            {
                get { return _ConcentrationTextElement; }
                set { _ConcentrationTextElement = value; OnPropertyChanged("ConcentrationTextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ConcentrationTextElement;
            
            /// <summary>
            /// A textual represention of either the whole of the concentration strength or a part of it - with the rest being in Strength.concentration as a ratio
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ConcentrationText
            {
                get { return ConcentrationTextElement != null ? ConcentrationTextElement.Value : null; }
                set
                {
                    if (value == null)
                        ConcentrationTextElement = null; 
                    else
                        ConcentrationTextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("ConcentrationText");
                }
            }
            
            /// <summary>
            /// For when strength is measured at a particular point or distance
            /// </summary>
            [FhirElement("measurementPoint", InSummary=true, Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MeasurementPointElement
            {
                get { return _MeasurementPointElement; }
                set { _MeasurementPointElement = value; OnPropertyChanged("MeasurementPointElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MeasurementPointElement;
            
            /// <summary>
            /// For when strength is measured at a particular point or distance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MeasurementPoint
            {
                get { return MeasurementPointElement != null ? MeasurementPointElement.Value : null; }
                set
                {
                    if (value == null)
                        MeasurementPointElement = null; 
                    else
                        MeasurementPointElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MeasurementPoint");
                }
            }
            
            /// <summary>
            /// The country or countries for which the strength range applies
            /// </summary>
            [FhirElement("country", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Country
            {
                get { if(_Country==null) _Country = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Country; }
                set { _Country = value; OnPropertyChanged("Country"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Country;
            
            /// <summary>
            /// Strength expressed in terms of a reference substance
            /// </summary>
            [FhirElement("referenceStrength", InSummary=true, Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Ingredient.ReferenceStrengthComponent> ReferenceStrength
            {
                get { if(_ReferenceStrength==null) _ReferenceStrength = new List<Hl7.Fhir.Model.Ingredient.ReferenceStrengthComponent>(); return _ReferenceStrength; }
                set { _ReferenceStrength = value; OnPropertyChanged("ReferenceStrength"); }
            }
            
            private List<Hl7.Fhir.Model.Ingredient.ReferenceStrengthComponent> _ReferenceStrength;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StrengthComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Presentation != null) dest.Presentation = (Hl7.Fhir.Model.Ratio)Presentation.DeepCopy();
                    if(PresentationHighLimit != null) dest.PresentationHighLimit = (Hl7.Fhir.Model.Ratio)PresentationHighLimit.DeepCopy();
                    if(PresentationTextElement != null) dest.PresentationTextElement = (Hl7.Fhir.Model.FhirString)PresentationTextElement.DeepCopy();
                    if(Concentration != null) dest.Concentration = (Hl7.Fhir.Model.Ratio)Concentration.DeepCopy();
                    if(ConcentrationHighLimit != null) dest.ConcentrationHighLimit = (Hl7.Fhir.Model.Ratio)ConcentrationHighLimit.DeepCopy();
                    if(ConcentrationTextElement != null) dest.ConcentrationTextElement = (Hl7.Fhir.Model.FhirString)ConcentrationTextElement.DeepCopy();
                    if(MeasurementPointElement != null) dest.MeasurementPointElement = (Hl7.Fhir.Model.FhirString)MeasurementPointElement.DeepCopy();
                    if(Country != null) dest.Country = new List<Hl7.Fhir.Model.CodeableConcept>(Country.DeepCopy());
                    if(ReferenceStrength != null) dest.ReferenceStrength = new List<Hl7.Fhir.Model.Ingredient.ReferenceStrengthComponent>(ReferenceStrength.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new StrengthComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StrengthComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Presentation, otherT.Presentation)) return false;
                if( !DeepComparable.Matches(PresentationHighLimit, otherT.PresentationHighLimit)) return false;
                if( !DeepComparable.Matches(PresentationTextElement, otherT.PresentationTextElement)) return false;
                if( !DeepComparable.Matches(Concentration, otherT.Concentration)) return false;
                if( !DeepComparable.Matches(ConcentrationHighLimit, otherT.ConcentrationHighLimit)) return false;
                if( !DeepComparable.Matches(ConcentrationTextElement, otherT.ConcentrationTextElement)) return false;
                if( !DeepComparable.Matches(MeasurementPointElement, otherT.MeasurementPointElement)) return false;
                if( !DeepComparable.Matches(Country, otherT.Country)) return false;
                if( !DeepComparable.Matches(ReferenceStrength, otherT.ReferenceStrength)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StrengthComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Presentation, otherT.Presentation)) return false;
                if( !DeepComparable.IsExactly(PresentationHighLimit, otherT.PresentationHighLimit)) return false;
                if( !DeepComparable.IsExactly(PresentationTextElement, otherT.PresentationTextElement)) return false;
                if( !DeepComparable.IsExactly(Concentration, otherT.Concentration)) return false;
                if( !DeepComparable.IsExactly(ConcentrationHighLimit, otherT.ConcentrationHighLimit)) return false;
                if( !DeepComparable.IsExactly(ConcentrationTextElement, otherT.ConcentrationTextElement)) return false;
                if( !DeepComparable.IsExactly(MeasurementPointElement, otherT.MeasurementPointElement)) return false;
                if( !DeepComparable.IsExactly(Country, otherT.Country)) return false;
                if( !DeepComparable.IsExactly(ReferenceStrength, otherT.ReferenceStrength)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Presentation != null) yield return Presentation;
                    if (PresentationHighLimit != null) yield return PresentationHighLimit;
                    if (PresentationTextElement != null) yield return PresentationTextElement;
                    if (Concentration != null) yield return Concentration;
                    if (ConcentrationHighLimit != null) yield return ConcentrationHighLimit;
                    if (ConcentrationTextElement != null) yield return ConcentrationTextElement;
                    if (MeasurementPointElement != null) yield return MeasurementPointElement;
                    foreach (var elem in Country) { if (elem != null) yield return elem; }
                    foreach (var elem in ReferenceStrength) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Presentation != null) yield return new ElementValue("presentation", Presentation);
                    if (PresentationHighLimit != null) yield return new ElementValue("presentationHighLimit", PresentationHighLimit);
                    if (PresentationTextElement != null) yield return new ElementValue("presentationText", PresentationTextElement);
                    if (Concentration != null) yield return new ElementValue("concentration", Concentration);
                    if (ConcentrationHighLimit != null) yield return new ElementValue("concentrationHighLimit", ConcentrationHighLimit);
                    if (ConcentrationTextElement != null) yield return new ElementValue("concentrationText", ConcentrationTextElement);
                    if (MeasurementPointElement != null) yield return new ElementValue("measurementPoint", MeasurementPointElement);
                    foreach (var elem in Country) { if (elem != null) yield return new ElementValue("country", elem); }
                    foreach (var elem in ReferenceStrength) { if (elem != null) yield return new ElementValue("referenceStrength", elem); }
                }
            }

            
        }
        
        
        [FhirType("ReferenceStrengthComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class ReferenceStrengthComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ReferenceStrengthComponent"; } }
            
            /// <summary>
            /// Relevant reference substance
            /// </summary>
            [FhirElement("substance", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Substance
            {
                get { return _Substance; }
                set { _Substance = value; OnPropertyChanged("Substance"); }
            }
            
            private Hl7.Fhir.Model.Element _Substance;
            
            /// <summary>
            /// Strength expressed in terms of a reference substance
            /// </summary>
            [FhirElement("strength", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio Strength
            {
                get { return _Strength; }
                set { _Strength = value; OnPropertyChanged("Strength"); }
            }
            
            private Hl7.Fhir.Model.Ratio _Strength;
            
            /// <summary>
            /// Strength expressed in terms of a reference substance, upper limit
            /// </summary>
            [FhirElement("strengthHighLimit", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio StrengthHighLimit
            {
                get { return _StrengthHighLimit; }
                set { _StrengthHighLimit = value; OnPropertyChanged("StrengthHighLimit"); }
            }
            
            private Hl7.Fhir.Model.Ratio _StrengthHighLimit;
            
            /// <summary>
            /// For when strength is measured at a particular point or distance
            /// </summary>
            [FhirElement("measurementPoint", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MeasurementPointElement
            {
                get { return _MeasurementPointElement; }
                set { _MeasurementPointElement = value; OnPropertyChanged("MeasurementPointElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MeasurementPointElement;
            
            /// <summary>
            /// For when strength is measured at a particular point or distance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MeasurementPoint
            {
                get { return MeasurementPointElement != null ? MeasurementPointElement.Value : null; }
                set
                {
                    if (value == null)
                        MeasurementPointElement = null; 
                    else
                        MeasurementPointElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MeasurementPoint");
                }
            }
            
            /// <summary>
            /// The country or countries for which the strength range applies
            /// </summary>
            [FhirElement("country", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Country
            {
                get { if(_Country==null) _Country = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Country; }
                set { _Country = value; OnPropertyChanged("Country"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Country;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReferenceStrengthComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Substance != null) dest.Substance = (Hl7.Fhir.Model.Element)Substance.DeepCopy();
                    if(Strength != null) dest.Strength = (Hl7.Fhir.Model.Ratio)Strength.DeepCopy();
                    if(StrengthHighLimit != null) dest.StrengthHighLimit = (Hl7.Fhir.Model.Ratio)StrengthHighLimit.DeepCopy();
                    if(MeasurementPointElement != null) dest.MeasurementPointElement = (Hl7.Fhir.Model.FhirString)MeasurementPointElement.DeepCopy();
                    if(Country != null) dest.Country = new List<Hl7.Fhir.Model.CodeableConcept>(Country.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ReferenceStrengthComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReferenceStrengthComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Substance, otherT.Substance)) return false;
                if( !DeepComparable.Matches(Strength, otherT.Strength)) return false;
                if( !DeepComparable.Matches(StrengthHighLimit, otherT.StrengthHighLimit)) return false;
                if( !DeepComparable.Matches(MeasurementPointElement, otherT.MeasurementPointElement)) return false;
                if( !DeepComparable.Matches(Country, otherT.Country)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReferenceStrengthComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if( !DeepComparable.IsExactly(Strength, otherT.Strength)) return false;
                if( !DeepComparable.IsExactly(StrengthHighLimit, otherT.StrengthHighLimit)) return false;
                if( !DeepComparable.IsExactly(MeasurementPointElement, otherT.MeasurementPointElement)) return false;
                if( !DeepComparable.IsExactly(Country, otherT.Country)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Substance != null) yield return Substance;
                    if (Strength != null) yield return Strength;
                    if (StrengthHighLimit != null) yield return StrengthHighLimit;
                    if (MeasurementPointElement != null) yield return MeasurementPointElement;
                    foreach (var elem in Country) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Substance != null) yield return new ElementValue("substance", Substance);
                    if (Strength != null) yield return new ElementValue("strength", Strength);
                    if (StrengthHighLimit != null) yield return new ElementValue("strengthHighLimit", StrengthHighLimit);
                    if (MeasurementPointElement != null) yield return new ElementValue("measurementPoint", MeasurementPointElement);
                    foreach (var elem in Country) { if (elem != null) yield return new ElementValue("country", elem); }
                }
            }

            
        }
        
        
        [FhirType("SubstanceComponent", NamedBackboneElement=true)]
        [DataContract]
        public partial class SubstanceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SubstanceComponent"; } }
            
            /// <summary>
            /// A code that represents the ingredient substance
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
			[AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.Element _Code;
            
            /// <summary>
            /// Quantity of the substance or specified substance present in the manufactured item or pharmaceutical product
            /// </summary>
            [FhirElement("strength", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Ingredient.StrengthComponent> Strength
            {
                get { if(_Strength==null) _Strength = new List<Hl7.Fhir.Model.Ingredient.StrengthComponent>(); return _Strength; }
                set { _Strength = value; OnPropertyChanged("Strength"); }
            }
            
            private List<Hl7.Fhir.Model.Ingredient.StrengthComponent> _Strength;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.Element)Code.DeepCopy();
                    if(Strength != null) dest.Strength = new List<Hl7.Fhir.Model.Ingredient.StrengthComponent>(Strength.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SubstanceComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstanceComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Strength, otherT.Strength)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Strength, otherT.Strength)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Strength) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            public override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in Strength) { if (elem != null) yield return new ElementValue("strength", elem); }
                }
            }

            
        }
        
        
        /// <summary>
        /// An identifier or code by which the ingredient can be referenced
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// Ingredient role within a drug product e.g. Active ingredient, Excipient
        /// </summary>
        [FhirElement("role", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Role
        {
            get { return _Role; }
            set { _Role = value; OnPropertyChanged("Role"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Role;
        
        /// <summary>
        /// A classification of the ingredient identifying its precise purpose(s) in the drug product. This extends the Ingredient.role to add more detail. Example: Antioxidant, Alkalizing Agent
        /// </summary>
        [FhirElement("function", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Function
        {
            get { if(_Function==null) _Function = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Function; }
            set { _Function = value; OnPropertyChanged("Function"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Function;
        
        /// <summary>
        /// A general description of the ingredient, or any supporting text. May be used for an unstructured list of excipients
        /// </summary>
        [FhirElement("description", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Description
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged("Description"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Description;
        
        /// <summary>
        /// If the ingredient is a known or suspected allergen
        /// </summary>
        [FhirElement("allergenicIndicator", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean AllergenicIndicatorElement
        {
            get { return _AllergenicIndicatorElement; }
            set { _AllergenicIndicatorElement = value; OnPropertyChanged("AllergenicIndicatorElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _AllergenicIndicatorElement;
        
        /// <summary>
        /// If the ingredient is a known or suspected allergen
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? AllergenicIndicator
        {
            get { return AllergenicIndicatorElement != null ? AllergenicIndicatorElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  AllergenicIndicatorElement = null; 
                else
                  AllergenicIndicatorElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("AllergenicIndicator");
            }
        }
        
        /// <summary>
        /// The organization that manufactures this ingredient
        /// </summary>
        [FhirElement("manufacturer", InSummary=true, Order=140)]
        [CLSCompliant(false)]
		[References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Manufacturer
        {
            get { if(_Manufacturer==null) _Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(); return _Manufacturer; }
            set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Manufacturer;
        
        /// <summary>
        /// A specified substance that comprises this ingredient
        /// </summary>
        [FhirElement("specifiedSubstance", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Ingredient.SpecifiedSubstanceComponent> SpecifiedSubstance
        {
            get { if(_SpecifiedSubstance==null) _SpecifiedSubstance = new List<Hl7.Fhir.Model.Ingredient.SpecifiedSubstanceComponent>(); return _SpecifiedSubstance; }
            set { _SpecifiedSubstance = value; OnPropertyChanged("SpecifiedSubstance"); }
        }
        
        private List<Hl7.Fhir.Model.Ingredient.SpecifiedSubstanceComponent> _SpecifiedSubstance;
        
        /// <summary>
        /// The substance that comprises this ingredient
        /// </summary>
        [FhirElement("substance", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.Ingredient.SubstanceComponent Substance
        {
            get { return _Substance; }
            set { _Substance = value; OnPropertyChanged("Substance"); }
        }
        
        private Hl7.Fhir.Model.Ingredient.SubstanceComponent _Substance;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Ingredient;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(Role != null) dest.Role = (Hl7.Fhir.Model.CodeableConcept)Role.DeepCopy();
                if(Function != null) dest.Function = new List<Hl7.Fhir.Model.CodeableConcept>(Function.DeepCopy());
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(AllergenicIndicatorElement != null) dest.AllergenicIndicatorElement = (Hl7.Fhir.Model.FhirBoolean)AllergenicIndicatorElement.DeepCopy();
                if(Manufacturer != null) dest.Manufacturer = new List<Hl7.Fhir.Model.ResourceReference>(Manufacturer.DeepCopy());
                if(SpecifiedSubstance != null) dest.SpecifiedSubstance = new List<Hl7.Fhir.Model.Ingredient.SpecifiedSubstanceComponent>(SpecifiedSubstance.DeepCopy());
                if(Substance != null) dest.Substance = (Hl7.Fhir.Model.Ingredient.SubstanceComponent)Substance.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Ingredient());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Ingredient;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Role, otherT.Role)) return false;
            if( !DeepComparable.Matches(Function, otherT.Function)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(AllergenicIndicatorElement, otherT.AllergenicIndicatorElement)) return false;
            if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.Matches(SpecifiedSubstance, otherT.SpecifiedSubstance)) return false;
            if( !DeepComparable.Matches(Substance, otherT.Substance)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Ingredient;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
            if( !DeepComparable.IsExactly(Function, otherT.Function)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(AllergenicIndicatorElement, otherT.AllergenicIndicatorElement)) return false;
            if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.IsExactly(SpecifiedSubstance, otherT.SpecifiedSubstance)) return false;
            if( !DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				if (Identifier != null) yield return Identifier;
				if (Role != null) yield return Role;
				foreach (var elem in Function) { if (elem != null) yield return elem; }
				if (Description != null) yield return Description;
				if (AllergenicIndicatorElement != null) yield return AllergenicIndicatorElement;
				foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
				foreach (var elem in SpecifiedSubstance) { if (elem != null) yield return elem; }
				if (Substance != null) yield return Substance;
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Role != null) yield return new ElementValue("role", Role);
                foreach (var elem in Function) { if (elem != null) yield return new ElementValue("function", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                if (AllergenicIndicatorElement != null) yield return new ElementValue("allergenicIndicator", AllergenicIndicatorElement);
                foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
                foreach (var elem in SpecifiedSubstance) { if (elem != null) yield return new ElementValue("specifiedSubstance", elem); }
                if (Substance != null) yield return new ElementValue("substance", Substance);
            }
        }

    }
    
}
