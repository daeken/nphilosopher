class PtrTest {
	unsafe static public void Main() {
		byte *ptr = (byte *) 0xB8000U;
		*ptr = (byte) 'H'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'e'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'l'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'l'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'o'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) ' '; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'W'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'o'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'r'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'l'; ptr++; *ptr = 0x0F; ptr++;
		*ptr = (byte) 'd'; ptr++; *ptr = 0x0F; ptr++;
		while(true) {}
	}
}
