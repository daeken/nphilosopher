class PtrTest {
	unsafe static byte *PutChar(char ch, byte *ptr) {
		ptr[0] = (byte) ch;
		ptr[1] = 0x0F;
		return ptr + 2;
	}
	
	unsafe static public void Main() {
		byte *ptr = (byte *) 0xB8000U;
		
		ptr = PutChar('C', ptr);
		ptr = PutChar('o', ptr);
		ptr = PutChar('l', ptr);
		ptr = PutChar('o', ptr);
		ptr = PutChar('r', ptr);
		ptr = PutChar('B', ptr);
		ptr = PutChar('l', ptr);
		ptr = PutChar('i', ptr);
		ptr = PutChar('n', ptr);
		ptr = PutChar('d', ptr);
		
		while(true) {}
	}
}
