<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">

<xsl:template match="CATALOG">
<html> 
<body>
  <h2>My CD Collection</h2>
  <table border="1px">
    <tr bgcolor="purple">
      <th style="text-align:left">Title</th>
      <th style="text-align:left">Artist</th>
      <th style="text-align:left">PRICE</th>
    </tr>
    <xsl:for-each select="CD[PRICE > 10]">

    <tr>
		
          <td><xsl:value-of select="TITLE"/></td>
		  <td><xsl:value-of select="ARTIST"/></td>
                  <td><xsl:value-of select="PRICE"/></td>
		
    </tr>

    </xsl:for-each>
  </table>
</body>
</html>
</xsl:template>

</xsl:stylesheet>