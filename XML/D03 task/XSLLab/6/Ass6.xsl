<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">

<xsl:template match="CATALOG">
<html> 
<body>
  <h2>My CD Collection</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
      <th style="text-align:center">Title</th>
      <th style="text-align:center">Artist</th>
    </tr>
    <xsl:for-each select="CD">   
    <tr>
      <xsl:choose>
		<xsl:when test="PRICE>10">	    
			 <td><xsl:value-of select="TITLE"/></td>
		     <td style="background-color:red"><xsl:value-of select="ARTIST"/></td>
		</xsl:when>
		<xsl:otherwise>
			 <td><xsl:value-of select="TITLE"/></td>
		     <td style="background-color:lightgreen"><xsl:value-of select="ARTIST"/></td>
		</xsl:otherwise>
	  </xsl:choose>
				</tr>
    </xsl:for-each>
  </table>
</body>
</html>
</xsl:template>

</xsl:stylesheet>
