﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Twenty57.Linx.Components.Pdf.PdfOperations.Templates
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class FillFormTemplate : FillFormTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 3 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
 
	string readerPropertyName = "reader";

            
            #line default
            #line hidden
            this.Write("\r\nif (");
            
            #line 7 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FillFormFormDataParameterName));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n\tthrow new ArgumentNullException(\"");
            
            #line 8 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FillFormFormDataParameterName));
            
            #line default
            #line hidden
            this.Write("\");\r\nif (string.IsNullOrEmpty(");
            
            #line 9 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutputFilePathParameterName));
            
            #line default
            #line hidden
            this.Write("))\r\n\tthrow new ArgumentNullException(\"");
            
            #line 10 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutputFilePathParameterName));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\niTextSharp.text.pdf.PdfReader ");
            
            #line 12 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));
            
            #line default
            #line hidden
            this.Write(" = null;\r\ntry\r\n{\r\n");
            
            #line 15 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
 
AssignPdfReader(readerPropertyName, InputAuthenticationType, InputFilePathParameterName, InputPasswordParameterName, 
	InputCertificateSource, InputCertificateFilePathParameterName, InputCertificateFilePasswordParameterName, InputCertificate, ContextParameterName); 

            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 20 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContextParameterName));
            
            #line default
            #line hidden
            this.Write(".Log(string.Format(\"Adding form data to [{0}].\", ");
            
            #line 20 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutputFilePathParameterName));
            
            #line default
            #line hidden
            this.Write("));\r\n\tusing (var outputStream = new System.IO.FileStream(");
            
            #line 21 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OutputFilePathParameterName));
            
            #line default
            #line hidden
            this.Write(", System.IO.FileMode.Create))\r\n\tusing (var pdfStamper = new iTextSharp.text.pdf.P" +
                    "dfStamper(");
            
            #line 22 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));
            
            #line default
            #line hidden
            this.Write(", outputStream, ");
            
            #line 22 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));
            
            #line default
            #line hidden
            this.Write(@".PdfVersion, true))
	{
		bool isXfa = pdfStamper.AcroFields.Xfa.XfaPresent;
		iTextSharp.text.pdf.AcroFields form = pdfStamper.AcroFields;
		System.Collections.Generic.Dictionary<string,string> keyMappings;

		if (isXfa)
			keyMappings = form.Xfa.DatasetsSom.Name2Node.Keys.ToDictionary(key => Twenty57.Linx.Plugin.Common.Names.GetValidName(key), key => key);
		else
			keyMappings = form.Fields.Keys.ToDictionary(key => Twenty57.Linx.Plugin.Common.Names.GetValidName(key), key => key);


		foreach (System.Reflection.PropertyInfo property in ");
            
            #line 34 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FillFormFormDataParameterName));
            
            #line default
            #line hidden
            this.Write(".GetType().GetProperties())\r\n\t\t{\r\n\t\t\tobject objectValue = property.GetValue(");
            
            #line 36 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FillFormFormDataParameterName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\tstring stringValue = objectValue.ToString();\r\n\t\t\tif (property.PropertyType" +
                    " == typeof(bool))\r\n\t\t\t\tstringValue = ((bool)objectValue)? \"Yes\" : \"No\";\r\n\r\n\t\t\tst" +
                    "ring fieldName = keyMappings[property.Name];\r\n\t\t\t");
            
            #line 42 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContextParameterName));
            
            #line default
            #line hidden
            this.Write(".Log(string.Format(\"Setting field [{0}] to [{1}].\", fieldName, stringValue));\r\n\t\t" +
                    "\tform.SetField(fieldName, stringValue);\r\n\t\t}\r\n\t}\r\n}\r\nfinally\r\n{\r\n");
            
            #line 49 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\FillFormTemplate.tt"
 DisposePdfReader(readerPropertyName); 
            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

void AssignPdfReader(string readerPropertyName, AuthenticationType authenticationType, string filePropertyName, string passwordPropertyName,
	Twenty57.Linx.Components.Pdf.CertificateSource certificateSource, string certificateFilePathPropertyName, string certificateFilePasswordPropertyName, 
	Twenty57.Linx.Components.Pdf.StoredCertificate certificate,	string contextPropertyName)
{

        
        #line default
        #line hidden
        
        #line 6 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("if (string.IsNullOrEmpty(");

        
        #line default
        #line hidden
        
        #line 7 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 7 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("))\r\n\tthrow new ArgumentNullException(\"");

        
        #line default
        #line hidden
        
        #line 8 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 8 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("\");\r\nif (!System.IO.File.Exists(");

        
        #line default
        #line hidden
        
        #line 9 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 9 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("))\r\n\tthrow new System.IO.FileNotFoundException(string.Format(\"File [{0}] does not" +
        " exist.\", ");

        
        #line default
        #line hidden
        
        #line 10 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 10 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("));\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 12 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(contextPropertyName));

        
        #line default
        #line hidden
        
        #line 12 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(".Log(string.Format(\"Opening file [{0}].\", ");

        
        #line default
        #line hidden
        
        #line 12 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 12 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 13 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

	if (authenticationType == AuthenticationType.None)
	{

        
        #line default
        #line hidden
        
        #line 17 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));

        
        #line default
        #line hidden
        
        #line 17 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" = new iTextSharp.text.pdf.PdfReader(");

        
        #line default
        #line hidden
        
        #line 17 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 17 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 18 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

	}
	else if (authenticationType == AuthenticationType.Password)
	{

        
        #line default
        #line hidden
        
        #line 23 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));

        
        #line default
        #line hidden
        
        #line 23 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" = new iTextSharp.text.pdf.PdfReader(");

        
        #line default
        #line hidden
        
        #line 23 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 23 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(", System.Text.Encoding.UTF8.GetBytes(");

        
        #line default
        #line hidden
        
        #line 23 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(passwordPropertyName));

        
        #line default
        #line hidden
        
        #line 23 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

	}
	else if (authenticationType == AuthenticationType.Certificate)
	{
		string certificatePropertyName = "inputCertificate";

        
        #line default
        #line hidden
        
        #line 29 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("System.Security.Cryptography.X509Certificates.X509Certificate2 ");

        
        #line default
        #line hidden
        
        #line 30 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(certificatePropertyName));

        
        #line default
        #line hidden
        
        #line 30 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" = null;\r\n");

        
        #line default
        #line hidden
        
        #line 31 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
 AssignCertificateProperty(certificatePropertyName, certificateSource, certificateFilePathPropertyName, certificateFilePasswordPropertyName, certificate); 
        
        #line default
        #line hidden
        
        #line 31 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(@"if (!inputCertificate.HasPrivateKey)
	throw new NotSupportedException(""Certificate must have a private key."");

Org.BouncyCastle.X509.X509Certificate inputBouncyCertficate = Org.BouncyCastle.Security.DotNetUtilities.FromX509Certificate(inputCertificate);
Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair inputKeyPair = Org.BouncyCastle.Security.DotNetUtilities.GetKeyPair(inputCertificate.PrivateKey);
");

        
        #line default
        #line hidden
        
        #line 37 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));

        
        #line default
        #line hidden
        
        #line 37 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" = new iTextSharp.text.pdf.PdfReader(");

        
        #line default
        #line hidden
        
        #line 37 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(filePropertyName));

        
        #line default
        #line hidden
        
        #line 37 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(", inputBouncyCertficate, inputKeyPair.Private);\r\n");

        
        #line default
        #line hidden
        
        #line 38 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

	}
}

        
        #line default
        #line hidden
        
        #line 43 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

void DisposePdfReader(string readerPropertyName)
{

        
        #line default
        #line hidden
        
        #line 46 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("if (");

        
        #line default
        #line hidden
        
        #line 47 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));

        
        #line default
        #line hidden
        
        #line 47 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" != null)\r\n\t");

        
        #line default
        #line hidden
        
        #line 48 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(readerPropertyName));

        
        #line default
        #line hidden
        
        #line 48 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(".Dispose();\r\n");

        
        #line default
        #line hidden
        
        #line 49 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

}

        
        #line default
        #line hidden
        
        #line 53 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

void AssignCertificateProperty(string certificatePropertyName, Twenty57.Linx.Components.Pdf.CertificateSource certificateSource, 
	string certificateFilePathPropertyName, string certificateFilePasswordPropertyName, 
	Twenty57.Linx.Components.Pdf.StoredCertificate storedCertificatePropertyName)
{

        
        #line default
        #line hidden
        
        #line 59 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
	if (certificateSource == Twenty57.Linx.Components.Pdf.CertificateSource.File)	{ 
        
        #line default
        #line hidden
        
        #line 60 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(certificatePropertyName));

        
        #line default
        #line hidden
        
        #line 60 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" = new System.Security.Cryptography.X509Certificates.X509Certificate2(");

        
        #line default
        #line hidden
        
        #line 60 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(certificateFilePathPropertyName));

        
        #line default
        #line hidden
        
        #line 60 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 60 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(certificateFilePasswordPropertyName));

        
        #line default
        #line hidden
        
        #line 60 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(", System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.Exportable);\r" +
        "\n");

        
        #line default
        #line hidden
        
        #line 61 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
 } else if (certificateSource == Twenty57.Linx.Components.Pdf.CertificateSource.Store) { 
        
        #line default
        #line hidden
        
        #line 62 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(certificatePropertyName));

        
        #line default
        #line hidden
        
        #line 62 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(" = new Twenty57.Linx.Components.Pdf.StoredCertificate(\r\n\t");

        
        #line default
        #line hidden
        
        #line 63 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(Twenty57.Linx.Plugin.Common.CodeGeneration.CSharpUtilities.EnumAsString(storedCertificatePropertyName.StoreLocation)));

        
        #line default
        #line hidden
        
        #line 63 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(", \r\n\t");

        
        #line default
        #line hidden
        
        #line 64 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(Twenty57.Linx.Plugin.Common.CodeGeneration.CSharpUtilities.EnumAsString(storedCertificatePropertyName.StoreName)));

        
        #line default
        #line hidden
        
        #line 64 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(", \r\n\t\"");

        
        #line default
        #line hidden
        
        #line 65 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write(this.ToStringHelper.ToStringWithCulture(storedCertificatePropertyName.ThumbPrint));

        
        #line default
        #line hidden
        
        #line 65 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
this.Write("\").GetCertificate();\r\n");

        
        #line default
        #line hidden
        
        #line 66 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"
	} 
        
        #line default
        #line hidden
        
        #line 67 "C:\Digiata\Projects\Linx5-Components-PDF_Dev1\src\Pdf\PdfOperations\Templates\..\..\Common\ManagePdfReaderTemplate.t4"

}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal class FillFormTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
