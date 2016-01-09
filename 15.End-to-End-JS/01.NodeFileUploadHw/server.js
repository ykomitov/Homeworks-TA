'use strict';

let http = require('http'),
  fs = require('fs'),
  formidable = require('formidable'),
  util = require('util'),
  url = require('url'),
  jade = require('jade'),
  path = require('path'),
  Guid = require('guid');

let port = 6666;

// Create the web server
http.createServer(function (req, res) {

  // Check if the "uploaded" directory exists and create it if necessary
  fs.existsSync('uploaded') || fs.mkdirSync('uploaded');

  // Function visualizing the files, uploaded on the server
  function visualizeUploadedFiles() {
    fs.readFile('uploadedFiles.jade', function (err, template) {
      if (err) {
        res.end(err);
        return;
      }

      fs.readdir('uploaded', function (error, files) {
        if (error) {
          resp.end(error);
          return;
        }

        let output = jade.compile(template)({
          files: files
        });

        res.writeHead(200, {'Content-Type': 'text/html'});
        res.write(output);
        res.end();
      })
    });
  }

  if (req.url == '/upload' && req.method.toLowerCase() == 'post') {

    // parse the file upload
    var form = new formidable.IncomingForm();
    var guid = Guid.create();

    form.parse(req, function (err, fields, files) {
      if (err) {
        throw 'Something bad happened!';
      }
    });

    form.on('end', function (fields, files) {
      let uploadedFilePath = this.openedFiles[0].path;
      let originalFileName = this.openedFiles[0].name;
      let originalFileExtension = originalFileName.substr(originalFileName.lastIndexOf('.') + 1);
      let new_location = __dirname + '/uploaded/';

      // Prompt user to select file in no file is selected & upload is clicked
      if (!originalFileName) {
        res.writeHead(200, {'content-type': 'text/html'});
        res.end(
          '<h2>Please select a file to upload!</h2>' +
          '<br>' +
          '<a href="/">Back</a>' +
          '</h2>'
        );
        return;
      }

      // Copy the uploaded file in the upload directory
      fs.createReadStream(uploadedFilePath).pipe(fs.createWriteStream(new_location + guid.value + '.' + originalFileExtension));
      visualizeUploadedFiles();
    });

    return;
  }

  // Display page listing the files in the 'uploaded' folder
  if (req.url.indexOf('files') >= 0 && req.method.toLowerCase() == 'get') {
    visualizeUploadedFiles();
    return;
  }

  if (req.url.indexOf('download') >= 0) {
    let fileNameToDownload = req.url.substr(req.url.lastIndexOf('/') + 1);
    let filePath = 'uploaded/' + fileNameToDownload;

    fs.exists(filePath, function (exists) {

      if (exists) {
        fs.readFile(filePath, function (error, content) {
          if (error) {
            res.writeHead(500);
            res.end();
          }
          else {
            res.writeHead(200, {'Content-Type': 'Magic'});
            res.end(content, 'utf-8');
          }
        });
      }
      else {
        res.writeHead(404);
        res.end();
      }
    });

    return;
  }

  // show a file upload form
  res.writeHead(200, {'content-type': 'text/html'});
  res.end(
    '<form action="/upload" enctype="multipart/form-data" method="post">' +
    '<input id="uploadInput" type="file" name="upload" multiple="multiple"><br>' +
    '<input type="submit" value="Upload">' +
    '<br>' +
    '<a href="/files">See uploaded files</a>' +
    '</form>'
  );
}).listen(port);

console.log(`Server running at port ${port}!`);
