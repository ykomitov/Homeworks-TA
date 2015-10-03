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
          <h1>Albums</h1>
          <table class="table table-striped table-hover">
            <thead>
              <tr>
                <th>Album Name</th>
                <th>Artist Name</th>
                <th>Year</th>
                <th>Producer</th>
                <th>Price</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
              <xsl:for-each select="/catalogue/album">
                <tr>
                  <td>
                    <xsl:value-of select="name"/>
                  </td>
                  <td>
                    <xsl:value-of select="artist"/>
                  </td>
                  <td>
                    <xsl:value-of select="year"/>
                  </td>
                  <td>
                    <xsl:value-of select="producer"/>
                  </td>
                  <td>
                    <xsl:value-of select="price"/>
                  </td>
                  <td>
                    <button type="button">
                      <xsl:attribute name="id">
                        <xsl:value-of select="name" />
                      </xsl:attribute>Show songs
                    </button>
                  </td>
                </tr>

                <tr style="text-align:center; display:none;">
                  <xsl:attribute name="class">
                    <xsl:value-of select="name" />
                  </xsl:attribute>
                  <td>
                    <strong>N</strong>
                  </td>
                  <td colspan="3">
                    <strong>Song Name</strong>
                  </td>
                  <td colspan="2">
                    <strong>Duration</strong>
                  </td>
                </tr>
                <xsl:for-each select="songs/song">
                  <tr style="text-align:center;display:none;">
                    <xsl:attribute name="class">
                      <xsl:value-of select="../../name" />
                    </xsl:attribute>
                    <td colspan="1">
                      <countNo>
                        <xsl:value-of select="position()" />
                      </countNo>
                    </td>
                    <td colspan="3">
                      <xsl:value-of select="title"/>
                    </td>
                    <td colspan="2">
                      <xsl:value-of select="duration"/>
                    </td>
                  </tr>
                </xsl:for-each>

              </xsl:for-each>
            </tbody>
          </table>
        </div>
        <script type="text/javascript">
          var buttons =  document.querySelectorAll('button');

          <![CDATA[
          for (var i = 0; i != buttons.length; i++) {
		  
		  buttons[i].addEventListener( 'click', function(ev) {
           var album = ev.target.id;
		   var targetRows = document.getElementsByClassName(album);
		   
		   for (var j = 0; j != targetRows.length; j++) {
		   if(targetRows[j].style.display === 'none'){
		   targetRows[j].style.display = '';
		   }else{
		   targetRows[j].style.display = 'none';
		   }
		   }
        } );
}       
          ]]>
        </script>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>