//dont let this work
//This might be some asm work
using System;
using Acme.Collections;

class This_not_asm_isit{//this is an instance. you can refer to it using this
	static void Main() {
		Stack s = new Stack();
		s.Push(1);// this is awesome. Push 1, rpd
		s.Push(10);//Push 10, rpd #this loads10 right after 1 in the hardware stack register(r5)
		s.Push(100);
		Console.WriteLine(s.Pop());
		Console.WriteLine(s.Pop());
		Console.WriteLine(s.Pop());
	}
}
