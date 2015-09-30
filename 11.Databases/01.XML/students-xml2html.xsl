<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
    <head>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css"/>
    </head>
  <body>
    <div class="modal-dialog">
  <h1>Students</h1>
  <table class="table table-striped table-hover">
    <thead>
      <tr>
        <th>Name</th>
        <th>Sex</th>
        <th>Birthday</th>
        <th>Phone</th>
        <th>Email</th>
        <th>Faculty Number</th>
      </tr>
    </thead>
    <tbody>
	    <xsl:for-each select="/students/student">
          <tr>
            <td><xsl:value-of select="name"/></td>
            <td><xsl:value-of select="sex"/></td>
            <td><xsl:value-of select="birthday"/></td>
            <td><xsl:value-of select="phone"/></td>
            <td><xsl:value-of select="email"/></td>
            <td><xsl:value-of select="facultyNum"/></td>
          </tr>
	    </xsl:for-each>
    </tbody>
  </table>
    </div>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>