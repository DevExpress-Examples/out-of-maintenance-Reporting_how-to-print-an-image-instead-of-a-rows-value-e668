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


