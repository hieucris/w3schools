
function runCode() {
    var bUrl = "https://localhost:44322";
	iframe = (iframe.contentWindow) ? iframe.contentWindow : (iframe.contentDocument.document) ? iframe.contentDocument.document : iframe.contentDocument;
	iframe.document.open();
    var header = '<!DOCTYPE html>' +
        '<html lang="en">' +
        '<head>' +
        '<meta charset="utf-8"/>' +
        '<meta name="viewport" content="width=device-width, initial-scale=1.0" />' +
        '<!--bootstrap, jquery w3schools-->' +
        '<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">' +
        '<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>' +
        ' <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>' +
        '<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>' +
        '<script type="text/javascript" src="http://js.nicedit.com/nicEdit-latest.js"></script>' +
        '<!--devextreme-->' +
        '<link rel="stylesheet" type="text/css" href="https://cdn3.devexpress.com/jslib/21.1.6/css/dx.common.css" />' +
        '<link rel="stylesheet" type="text/css" href="https://cdn3.devexpress.com/jslib/21.1.6/css/dx.light.css" />' +
        '<script src="https://unpkg.com/devextreme-quill/dist/dx-quill.min.js"></script>' +
        '<script src="https://cdn3.devexpress.com/jslib/21.1.6/js/dx.all.js"></script>' +
        '<!--front-end-->' +
        '<link href="'+bUrl+'/css/site.css" rel="stylesheet"/>' +
        '<link href="' + bUrl +'/css/base.css" rel="stylesheet"/>' +
        '<script src="' + bUrl +'/js/site.js"></script>' +        
        '<!--font-awesome-->' +
        '<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">' +
        
                
        '</head>' +
        '<body>';
	iframe.document.write(header+content);
	iframe.document.close();
	return false;
}