A22 - Logical Error 3

Felet ligger i kodraden for (int i = 0; i < numbers.Length; i++)
I villkoret ska det inte vara <= utan bara i < numbers.Length; 
Eftersom det finns fyra positioner (0-4) i arrayen, men Length är 5 går det inte att söka position 5. 
