<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Image Steganography</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <style type="text/css">
        .display-6 {
            font-size: 1.5rem;
            font-weight: 300;
            line-height: 1.2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron jumbotron-fluid">
            <div class="container">
                <h1 class="display-4"><i class="fas fa-image"></i>&nbsp;Image Steganography</h1>
                <p class="lead">
                    Steganography is a technique consisting of a series of methodologies applied in different multimedia mediums to conceal a secret message in a carrier so that the secret message can’t be recognized and noticed.
                </p>
                <footer class="blockquote-footer">KASAPBAŞI M. C., 2019. <cite title="Source Title">"A New Chaotic Image Steganography Technique Based on Huffman Compression of Turkish Texts and Fractal Encryption With Post-Quantum Security"</cite></footer>
            </div>
        </div>
        <div class="container mb-5">
            <div class="row">
                <div class="col-12">
                    <div class="alert alert-primary" role="alert">
                        Firstly, upload your image in order to encode or decode your message !
                    </div>
                </div>
                <div class="col-12">
                    <div class="custom-file">
                        <asp:FileUpload ID="fuImage" CssClass="custom-file-input" runat="server" />
                        <label class="custom-file-label" for="customFileLang">In order to the system to work properly, only select a picture with the .bmp extension.</label>
                    </div>
                </div>
            </div>
            <hr />
            <asp:Panel ID="pnlAfterLoad" runat="server" CssClass="row">
                <div class="col-4 text-center">
                    <asp:Image ID="imgAllPlane" CssClass="img-thumbnail" runat="server" />
                    <p>Cover Image</p>
                </div>
                <div class="col-8 mb-5">
                    <div class="row">
                        <div class="col-3 text-center">
                            <asp:Image ID="img1Plane" CssClass="img-thumbnail" runat="server" />
                            <p>1st Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img2Plane" CssClass="img-thumbnail" runat="server" />
                            <p>2nd Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img3Plane" CssClass="img-thumbnail" runat="server" />
                            <p>3rd Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img4Plane" CssClass="img-thumbnail" runat="server" />
                            <p>4th Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img5Plane" CssClass="img-thumbnail" runat="server" />
                            <p>5th Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img6Plane" CssClass="img-thumbnail" runat="server" />
                            <p>6th Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img7Plane" CssClass="img-thumbnail" runat="server" />
                            <p>7th Plane</p>
                        </div>
                        <div class="col-3 text-center">
                            <asp:Image ID="img8Plane" CssClass="img-thumbnail" runat="server" />
                            <p>8th Plane</p>
                        </div>
                    </div>
                </div>
                <div class="col-6">
                    <h3 class="text-danger"><i class="fas fa-key"></i>&nbsp;Decoded Message</h3>
                    <hr />
                    <p class="display-6">
                    Lorem ipsum dolor sit amet, consecetur adipiscing elit. Aliquam commodo, diam sed ullamcorper pretium, dolor elit semper risus, vitae vulputate tellus nisl ut turpis. Fusce at orci lorem. Pellentesque eros risus, efficitur vel neque id, ornare egestas leo. Nullam ut risus convallis, varius justo sed, volutpat magna. Mauris ullamcorper tellus non neque sollicitudin rhoncus. Nullam ac arcu tincidunt, suscipit justo sed, lacinia felis. In hac habitasse platea dictumst. Proin vulputate dolor sed ultrices pretium. Nulla facilisi. Phasellus tincidunt lacus erat, eget accumsan tellus vestibulum eget.</h5>
                </div>

                <div class="col-6">
                    <h3 class="text-danger"><i class="fas fa-lock"></i>&nbsp;Encode A New Message</h3>
                    <hr />
                    <asp:TextBox ID="txtMessage" CssClass="form-control" TextMode="MultiLine" Height="250" runat="server"></asp:TextBox>
                    <hr />
                    <asp:Button ID="btnSave" CssClass="btn  btn-lg btn-block btn-success" runat="server" Text="Encode Message" />
                </div>
            </asp:Panel>
        </div>

        <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
        <script src="https://kit.fontawesome.com/91d613790b.js"></script>
    </form>
</body>
</html>
