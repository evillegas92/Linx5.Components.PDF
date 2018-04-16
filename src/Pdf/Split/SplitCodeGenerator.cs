﻿using System;
using iTextSharp.text.pdf;
using Twenty57.Linx.Components.Pdf.Split.Templates;
using Twenty57.Linx.Plugin.Common;
using Twenty57.Linx.Plugin.Common.CodeGeneration;

namespace Twenty57.Linx.Components.Pdf.Split
{
	internal class SplitCodeGenerator : FunctionCodeGenerator
	{
		public SplitCodeGenerator(IFunctionData data) : base(data)	{	}

		public override void GenerateCode(IFunctionBuilder functionBuilder)
		{
			functionBuilder.AddAssemblyReference(GetType());
			functionBuilder.AddAssemblyReference(typeof(Uri));
			functionBuilder.AddAssemblyReference(typeof(PdfReader));

			SplitTemplate template = new SplitTemplate();
			template.Populate(functionBuilder, FunctionData);
			functionBuilder.AddCode(template.TransformText());
		}
	}
}