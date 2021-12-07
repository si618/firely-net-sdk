// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

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

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Group of multiple entities
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Group","http://hl7.org/fhir/StructureDefinition/Group", IsResource=true)]
  public partial class Group : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Group"; } }

    /// <summary>
    /// Types of resources that are part of group
    /// (url: http://hl7.org/fhir/ValueSet/group-type)
    /// (system: http://hl7.org/fhir/group-type)
    /// </summary>
    [FhirEnumeration("GroupType")]
    public enum GroupType
    {
      /// <summary>
      /// Group contains "person" Patient resources
      /// (system: http://hl7.org/fhir/group-type)
      /// </summary>
      [EnumLiteral("person", "http://hl7.org/fhir/group-type"), Description("Person")]
      Person,
      /// <summary>
      /// Group contains "animal" Patient resources
      /// (system: http://hl7.org/fhir/group-type)
      /// </summary>
      [EnumLiteral("animal", "http://hl7.org/fhir/group-type"), Description("Animal")]
      Animal,
      /// <summary>
      /// Group contains healthcare practitioner resources
      /// (system: http://hl7.org/fhir/group-type)
      /// </summary>
      [EnumLiteral("practitioner", "http://hl7.org/fhir/group-type"), Description("Practitioner")]
      Practitioner,
      /// <summary>
      /// Group contains Device resources
      /// (system: http://hl7.org/fhir/group-type)
      /// </summary>
      [EnumLiteral("device", "http://hl7.org/fhir/group-type"), Description("Device")]
      Device,
      /// <summary>
      /// Group contains Medication resources
      /// (system: http://hl7.org/fhir/group-type)
      /// </summary>
      [EnumLiteral("medication", "http://hl7.org/fhir/group-type"), Description("Medication")]
      Medication,
      /// <summary>
      /// Group contains Substance resources
      /// (system: http://hl7.org/fhir/group-type)
      /// </summary>
      [EnumLiteral("substance", "http://hl7.org/fhir/group-type"), Description("Substance")]
      Substance,
    }

    /// <summary>
    /// Trait of group members
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Group#Characteristic", IsNestedType=true)]
    public partial class CharacteristicComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Group#Characteristic"; } }

      /// <summary>
      /// Kind of characteristic
      /// </summary>
      [FhirElement("code", Order=40)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Code
      {
        get { return _Code; }
        set { _Code = value; OnPropertyChanged("Code"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Code;

      /// <summary>
      /// Value held by characteristic
      /// </summary>
      [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Quantity),typeof(Hl7.Fhir.Model.Range))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.DataType _Value;

      /// <summary>
      /// Group includes or excludes
      /// </summary>
      [FhirElement("exclude", InSummary=true, Order=60)]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.FhirBoolean ExcludeElement
      {
        get { return _ExcludeElement; }
        set { _ExcludeElement = value; OnPropertyChanged("ExcludeElement"); }
      }

      private Hl7.Fhir.Model.FhirBoolean _ExcludeElement;

      /// <summary>
      /// Group includes or excludes
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public bool? Exclude
      {
        get { return ExcludeElement != null ? ExcludeElement.Value : null; }
        set
        {
          if (value == null)
            ExcludeElement = null;
          else
            ExcludeElement = new Hl7.Fhir.Model.FhirBoolean(value);
          OnPropertyChanged("Exclude");
        }
      }

      /// <summary>
      /// Period over which characteristic is tested
      /// </summary>
      [FhirElement("period", Order=70)]
      [DataMember]
      public Hl7.Fhir.Model.Period Period
      {
        get { return _Period; }
        set { _Period = value; OnPropertyChanged("Period"); }
      }

      private Hl7.Fhir.Model.Period _Period;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as CharacteristicComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.DataType)Value.DeepCopy();
        if(ExcludeElement != null) dest.ExcludeElement = (Hl7.Fhir.Model.FhirBoolean)ExcludeElement.DeepCopy();
        if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new CharacteristicComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as CharacteristicComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Code, otherT.Code)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;
        if( !DeepComparable.Matches(ExcludeElement, otherT.ExcludeElement)) return false;
        if( !DeepComparable.Matches(Period, otherT.Period)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as CharacteristicComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
        if( !DeepComparable.IsExactly(ExcludeElement, otherT.ExcludeElement)) return false;
        if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Code != null) yield return Code;
          if (Value != null) yield return Value;
          if (ExcludeElement != null) yield return ExcludeElement;
          if (Period != null) yield return Period;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Code != null) yield return new ElementValue("code", Code);
          if (Value != null) yield return new ElementValue("value", Value);
          if (ExcludeElement != null) yield return new ElementValue("exclude", ExcludeElement);
          if (Period != null) yield return new ElementValue("period", Period);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "code":
            value = Code;
            return Code is not null;
          case "value":
            value = Value;
            return Value is not null;
          case "exclude":
            value = ExcludeElement;
            return ExcludeElement is not null;
          case "period":
            value = Period;
            return Period is not null;
          default:
            return base.TryGetValue(key, out value);
        };

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
        if (Value is not null) yield return new KeyValuePair<string,object>("value",Value);
        if (ExcludeElement is not null) yield return new KeyValuePair<string,object>("exclude",ExcludeElement);
        if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      }

    }

    /// <summary>
    /// Who or what is in group
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Group#Member", IsNestedType=true)]
    public partial class MemberComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Group#Member"; } }

      /// <summary>
      /// Reference to the group member
      /// </summary>
      [FhirElement("entity", Order=40)]
      [CLSCompliant(false)]
      [References("Patient","Practitioner","Device","Medication","Substance")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Entity
      {
        get { return _Entity; }
        set { _Entity = value; OnPropertyChanged("Entity"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Entity;

      /// <summary>
      /// Period member belonged to the group
      /// </summary>
      [FhirElement("period", Order=50)]
      [DataMember]
      public Hl7.Fhir.Model.Period Period
      {
        get { return _Period; }
        set { _Period = value; OnPropertyChanged("Period"); }
      }

      private Hl7.Fhir.Model.Period _Period;

      /// <summary>
      /// If member is no longer in group
      /// </summary>
      [FhirElement("inactive", Order=60)]
      [DataMember]
      public Hl7.Fhir.Model.FhirBoolean InactiveElement
      {
        get { return _InactiveElement; }
        set { _InactiveElement = value; OnPropertyChanged("InactiveElement"); }
      }

      private Hl7.Fhir.Model.FhirBoolean _InactiveElement;

      /// <summary>
      /// If member is no longer in group
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public bool? Inactive
      {
        get { return InactiveElement != null ? InactiveElement.Value : null; }
        set
        {
          if (value == null)
            InactiveElement = null;
          else
            InactiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
          OnPropertyChanged("Inactive");
        }
      }

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as MemberComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Entity != null) dest.Entity = (Hl7.Fhir.Model.ResourceReference)Entity.DeepCopy();
        if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
        if(InactiveElement != null) dest.InactiveElement = (Hl7.Fhir.Model.FhirBoolean)InactiveElement.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new MemberComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as MemberComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Entity, otherT.Entity)) return false;
        if( !DeepComparable.Matches(Period, otherT.Period)) return false;
        if( !DeepComparable.Matches(InactiveElement, otherT.InactiveElement)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as MemberComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
        if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
        if( !DeepComparable.IsExactly(InactiveElement, otherT.InactiveElement)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Entity != null) yield return Entity;
          if (Period != null) yield return Period;
          if (InactiveElement != null) yield return InactiveElement;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Entity != null) yield return new ElementValue("entity", Entity);
          if (Period != null) yield return new ElementValue("period", Period);
          if (InactiveElement != null) yield return new ElementValue("inactive", InactiveElement);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "entity":
            value = Entity;
            return Entity is not null;
          case "period":
            value = Period;
            return Period is not null;
          case "inactive":
            value = InactiveElement;
            return InactiveElement is not null;
          default:
            return base.TryGetValue(key, out value);
        };

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Entity is not null) yield return new KeyValuePair<string,object>("entity",Entity);
        if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
        if (InactiveElement is not null) yield return new KeyValuePair<string,object>("inactive",InactiveElement);
      }

    }

    /// <summary>
    /// Unique id
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Whether this group's record is in active use
    /// </summary>
    [FhirElement("active", InSummary=true, Order=100)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ActiveElement
    {
      get { return _ActiveElement; }
      set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ActiveElement;

    /// <summary>
    /// Whether this group's record is in active use
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Active
    {
      get { return ActiveElement != null ? ActiveElement.Value : null; }
      set
      {
        if (value == null)
          ActiveElement = null;
        else
          ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Active");
      }
    }

    /// <summary>
    /// person | animal | practitioner | device | medication | substance
    /// </summary>
    [FhirElement("type", InSummary=true, Order=110)]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.Group.GroupType> TypeElement
    {
      get { return _TypeElement; }
      set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
    }

    private Code<Hl7.Fhir.Model.Group.GroupType> _TypeElement;

    /// <summary>
    /// person | animal | practitioner | device | medication | substance
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.Group.GroupType? Type
    {
      get { return TypeElement != null ? TypeElement.Value : null; }
      set
      {
        if (value == null)
          TypeElement = null;
        else
          TypeElement = new Code<Hl7.Fhir.Model.Group.GroupType>(value);
        OnPropertyChanged("Type");
      }
    }

    /// <summary>
    /// Descriptive or actual
    /// </summary>
    [FhirElement("actual", InSummary=true, Order=120)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ActualElement
    {
      get { return _ActualElement; }
      set { _ActualElement = value; OnPropertyChanged("ActualElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ActualElement;

    /// <summary>
    /// Descriptive or actual
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Actual
    {
      get { return ActualElement != null ? ActualElement.Value : null; }
      set
      {
        if (value == null)
          ActualElement = null;
        else
          ActualElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Actual");
      }
    }

    /// <summary>
    /// Kind of Group members
    /// </summary>
    [FhirElement("code", InSummary=true, Order=130)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Code
    {
      get { return _Code; }
      set { _Code = value; OnPropertyChanged("Code"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Code;

    /// <summary>
    /// Label for Group
    /// </summary>
    [FhirElement("name", InSummary=true, Order=140)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString NameElement
    {
      get { return _NameElement; }
      set { _NameElement = value; OnPropertyChanged("NameElement"); }
    }

    private Hl7.Fhir.Model.FhirString _NameElement;

    /// <summary>
    /// Label for Group
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Name
    {
      get { return NameElement != null ? NameElement.Value : null; }
      set
      {
        if (value == null)
          NameElement = null;
        else
          NameElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Name");
      }
    }

    /// <summary>
    /// Number of members
    /// </summary>
    [FhirElement("quantity", InSummary=true, Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.UnsignedInt QuantityElement
    {
      get { return _QuantityElement; }
      set { _QuantityElement = value; OnPropertyChanged("QuantityElement"); }
    }

    private Hl7.Fhir.Model.UnsignedInt _QuantityElement;

    /// <summary>
    /// Number of members
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public int? Quantity
    {
      get { return QuantityElement != null ? QuantityElement.Value : null; }
      set
      {
        if (value == null)
          QuantityElement = null;
        else
          QuantityElement = new Hl7.Fhir.Model.UnsignedInt(value);
        OnPropertyChanged("Quantity");
      }
    }

    /// <summary>
    /// Trait of group members
    /// </summary>
    [FhirElement("characteristic", Order=160)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Group.CharacteristicComponent> Characteristic
    {
      get { if(_Characteristic==null) _Characteristic = new List<Hl7.Fhir.Model.Group.CharacteristicComponent>(); return _Characteristic; }
      set { _Characteristic = value; OnPropertyChanged("Characteristic"); }
    }

    private List<Hl7.Fhir.Model.Group.CharacteristicComponent> _Characteristic;

    /// <summary>
    /// Who or what is in group
    /// </summary>
    [FhirElement("member", Order=170)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Group.MemberComponent> Member
    {
      get { if(_Member==null) _Member = new List<Hl7.Fhir.Model.Group.MemberComponent>(); return _Member; }
      set { _Member = value; OnPropertyChanged("Member"); }
    }

    private List<Hl7.Fhir.Model.Group.MemberComponent> _Member;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Group;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
      if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.Group.GroupType>)TypeElement.DeepCopy();
      if(ActualElement != null) dest.ActualElement = (Hl7.Fhir.Model.FhirBoolean)ActualElement.DeepCopy();
      if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
      if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
      if(QuantityElement != null) dest.QuantityElement = (Hl7.Fhir.Model.UnsignedInt)QuantityElement.DeepCopy();
      if(Characteristic != null) dest.Characteristic = new List<Hl7.Fhir.Model.Group.CharacteristicComponent>(Characteristic.DeepCopy());
      if(Member != null) dest.Member = new List<Hl7.Fhir.Model.Group.MemberComponent>(Member.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Group());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Group;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.Matches(ActualElement, otherT.ActualElement)) return false;
      if( !DeepComparable.Matches(Code, otherT.Code)) return false;
      if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.Matches(QuantityElement, otherT.QuantityElement)) return false;
      if( !DeepComparable.Matches(Characteristic, otherT.Characteristic)) return false;
      if( !DeepComparable.Matches(Member, otherT.Member)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Group;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
      if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
      if( !DeepComparable.IsExactly(ActualElement, otherT.ActualElement)) return false;
      if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
      if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
      if( !DeepComparable.IsExactly(QuantityElement, otherT.QuantityElement)) return false;
      if( !DeepComparable.IsExactly(Characteristic, otherT.Characteristic)) return false;
      if( !DeepComparable.IsExactly(Member, otherT.Member)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (ActiveElement != null) yield return ActiveElement;
        if (TypeElement != null) yield return TypeElement;
        if (ActualElement != null) yield return ActualElement;
        if (Code != null) yield return Code;
        if (NameElement != null) yield return NameElement;
        if (QuantityElement != null) yield return QuantityElement;
        foreach (var elem in Characteristic) { if (elem != null) yield return elem; }
        foreach (var elem in Member) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
        if (TypeElement != null) yield return new ElementValue("type", TypeElement);
        if (ActualElement != null) yield return new ElementValue("actual", ActualElement);
        if (Code != null) yield return new ElementValue("code", Code);
        if (NameElement != null) yield return new ElementValue("name", NameElement);
        if (QuantityElement != null) yield return new ElementValue("quantity", QuantityElement);
        foreach (var elem in Characteristic) { if (elem != null) yield return new ElementValue("characteristic", elem); }
        foreach (var elem in Member) { if (elem != null) yield return new ElementValue("member", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "active":
          value = ActiveElement;
          return ActiveElement is not null;
        case "type":
          value = TypeElement;
          return TypeElement is not null;
        case "actual":
          value = ActualElement;
          return ActualElement is not null;
        case "code":
          value = Code;
          return Code is not null;
        case "name":
          value = NameElement;
          return NameElement is not null;
        case "quantity":
          value = QuantityElement;
          return QuantityElement is not null;
        case "characteristic":
          value = Characteristic;
          return Characteristic?.Any() == true;
        case "member":
          value = Member;
          return Member?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      };

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (ActiveElement is not null) yield return new KeyValuePair<string,object>("active",ActiveElement);
      if (TypeElement is not null) yield return new KeyValuePair<string,object>("type",TypeElement);
      if (ActualElement is not null) yield return new KeyValuePair<string,object>("actual",ActualElement);
      if (Code is not null) yield return new KeyValuePair<string,object>("code",Code);
      if (NameElement is not null) yield return new KeyValuePair<string,object>("name",NameElement);
      if (QuantityElement is not null) yield return new KeyValuePair<string,object>("quantity",QuantityElement);
      if (Characteristic?.Any() == true) yield return new KeyValuePair<string,object>("characteristic",Characteristic);
      if (Member?.Any() == true) yield return new KeyValuePair<string,object>("member",Member);
    }

  }

}

// end of file
