<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602390/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E668)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E668/Form1.cs) (VB: [Form1.vb](./VB/E668/Form1.vb))
* [XtraReport1.cs](./CS/E668/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/E668/XtraReport1.vb))
<!-- default file list end -->
# How to print an image instead of a row's value


<p><strong>Description</strong>:<br />
My Products data table has a Category column which is of type Integer.  I wish to display icons from an image instead of product category codes.  How can I implement this with XtraReports?</p><p><strong>Solution</strong>:<br />
We advise that you use the <strong>XRPictureBox</strong> control and handle its <strong>BeforePrint</strong> event to dynamically change the image based on the current row's value.  Please use the <strong>GetCurrentColumnValue</strong> method to obtain a data row's value.  Below is some sample code.<br />
</p>

```cs
        private void XrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            MemoryStream ms = new MemoryStream((byte [])GetCurrentColumnValue("Picture"));
            ((XRPictureBox)sender).Image = Image.FromStream(ms);
        }

```

<p> </p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A2319">How to implement the look-up feature for the XRLabel</a></p>

<br/>


