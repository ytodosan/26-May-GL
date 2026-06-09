namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16cbb626-971e-49ec-8437-474c7f964a32");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2c437dd1-65d1-4bba-97f9-850f5d608775");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,223,107,219,48,16,199,223,11,253,31,14,63,217,16,68,247,186,110,133,37,164,163,80,182,209,56,131,50,246,160,200,23,71,67,63,140,78,78,151,141,254,239,59,89,73,155,58,29,244,94,108,157,190,250,220,125,143,115,210,34,117,82,33,212,24,130,36,191,142,98,230,221,90,183,125,144,81,123,119,126,246,247,252,12,56,122,210,174,133,197,142,34,218,203,227,212,241,67,107,189,251,239,101,64,49,119,81,71,141,244,22,141,152,111,209,197,131,244,199,144,222,13,185,91,205,77,56,12,229,66,109,208,202,47,236,1,62,66,177,164,112,47,213,38,82,81,253,204,143,186,126,101,180,2,101,36,17,12,119,175,80,224,61,76,37,225,43,55,25,178,247,127,196,243,91,238,88,55,8,91,175,27,248,234,22,114,203,62,74,191,250,133,42,2,161,107,48,76,32,3,167,184,102,83,3,246,83,104,9,176,122,198,29,145,83,172,184,11,241,68,59,96,176,186,124,41,203,92,216,37,59,108,187,204,231,42,235,71,218,6,149,182,210,64,23,180,74,51,26,30,137,207,24,235,93,135,205,204,155,222,186,239,210,244,248,97,175,188,42,211,24,191,37,121,49,46,172,215,80,102,208,21,188,187,72,81,189,20,140,252,164,64,113,67,51,233,20,26,108,184,126,12,61,50,245,84,71,49,164,85,224,101,36,217,98,141,182,51,50,166,142,29,62,192,173,87,210,232,63,114,101,112,49,232,202,236,99,73,24,120,89,29,79,157,55,85,220,33,249,62,40,214,248,192,144,201,105,149,20,79,107,146,215,171,152,64,113,194,39,49,12,229,134,106,239,167,186,205,167,162,18,181,223,215,175,222,96,130,155,207,9,113,237,131,149,177,28,153,227,194,60,69,224,49,194,124,121,119,50,237,20,113,19,252,195,48,130,249,111,133,93,114,121,160,140,229,143,207,199,253,47,127,30,255,1,132,245,14,58,223,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9295895c-7c72-9102-9b75-240009b0e45e"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("2c437dd1-65d1-4bba-97f9-850f5d608775"),
				CreatedInSchemaUId = new Guid("16cbb626-971e-49ec-8437-474c7f964a32"),
				ModifiedInSchemaUId = new Guid("16cbb626-971e-49ec-8437-474c7f964a32")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16cbb626-971e-49ec-8437-474c7f964a32"));
		}

		#endregion

	}

	#endregion

}

