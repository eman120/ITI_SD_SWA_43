<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="books">
	<h3>No. of books with review 3.5 = </h3>				
	  <xsl:value-of select="count(book[review='3.5'])" />
	<br></br>
<h4>No. of books with review 4 = </h4>

	<xsl:value-of select="count(book[review='4'])" />
	
 
</xsl:template>

</xsl:stylesheet>