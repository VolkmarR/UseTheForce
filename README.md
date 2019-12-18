![](Acs_Im_Logo.png)

# UseTheForce Riddle

You learned from old legends that an ancient force is protecting a **tremendous hidden treasure** in the form of a [rubber duck](https://en.wikipedia.org/wiki/Rubber_duck_debugging) somewhere in our galaxy close to [Ganymede](https://en.wikipedia.org/wiki/Ganymede_(moon)), a moon of Jupiter. You managed to triangulate the rubber duck using your [quantum supremacy chip](https://en.wikipedia.org/wiki/Quantum_supremacy). Luckily you bought the ["Heart of Gold"](https://en.wikipedia.org/wiki/Technology_in_The_Hitchhiker%27s_Guide_to_the_Galaxy#Heart_of_Gold) a first-class space shuttle with the first fully functional [Infinite Improbability Drive](https://en.wikipedia.org/wiki/Technology_in_The_Hitchhiker%27s_Guide_to_the_Galaxy#Infinite_Improbability_Drive) which takes you to Ganymede in no time!
Arrived on the moon you find yourself in front of a big door with a small display, a cursor is blinking. You're sure there must be some sort of password to open the door and recover the mysterious rubber duck.

Since you dont know the password, you use the **"I forgot my password"** button.

The software outputs the following text:
```
There is a mysterious code located under ./UseTheForce/Program.cs.
**Execute it and insert the result as new password.**
```

```
                    ____
                 _.' :  `._
             .-.'`.  ;   .'`.-.
    __      / : ___\ ;  /___ ; \      __
  ,'_ ""--.:__;".-.";: :".-.":__;.--"" _`,
  :' `.t""--.. '<@.`;_  ',@>` ..--""j.' `;
       `:-.._J '-.-'L__ `-- ' L_..-;'
         "-.__ ;  .-"  "-.  : __.-"
             L ' /.------.\ ' J
              "-.   "--"   .-"
             __.l"-:_JL_;-";.__
          .-j/'.;  ;""""  / .'\"-.
        .' /:`. "-.:     .-" .';  `.
     .-"  / ;  "-. "-..-" .-"  :    "-.
  .+"-.  : :      "-.__.-"      ;-._   \
  ; \  `.; ;                    : : "+. ;
  :  ;   ; ;                    : ;  : \:
 : `."-; ;  ;                  :  ;   ,/;
  ;    -: ;  :                ;  : .-"'  :
  :\     \  : ;             : \.-"      :
   ;`.    \  ; :            ;.'_..--  / ;
   :  "-.  "-:  ;          :/."      .'  :
     \       .-`.\        /t-""  ":-+.   :
      `.  .-"    `l    __/ /`. :  ; ; \  ;
        \   .-" .-"-.-"  .' .'j \  /   ;/
         \ / .-"   /.     .'.' ;_:'    ;
          :-""-.`./-.'     /    `.___.'
                \ `t  ._  /  bug :F_P:
                 "-.t-._:'
```

```csharp
using System;
namespace UseTheForce
{
	class YodaRiddle
	{
		public static string Message => "get your ";

		private static void Talk(int index = 0)
		{
			if (index < 4)
				Talk(index + 1);


			if (index == 1)
			{
				Console.Write(", ");
			}

			if (index == 0)
				Console.Write(Message + "rubber duck ".Trim());

			if (index % 2 == 0 && index > 0 && index < 4)
				Console.Write("force ".Trim());

			if (index == 3)
				Console.Write("use your ");
		}

		static void Main(string[] args)
		{
			Talk();
			Console.Write('!');
		}
	}
}
```

Unfortunately, you didn't bring a computer and a **c#** compiler. **Are you smart enough to trace the program's steps in your mind?**

Here are some options:

1. ``use your force, get your rubber duck!``

2. ``use your force, get your rubber duck``

3. ``get your rubber duck, use your force!``

4. ``get your rubber duck, force use your!``
