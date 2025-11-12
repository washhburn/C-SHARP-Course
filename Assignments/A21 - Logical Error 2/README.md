A21 - Logical Error 2

Felet ligger i logiken eller ordningen av if-satserna. Om variabeln age är 34 som i exemplet så uppfylls både första if-satsen och den andra. 
Eftersom koden först kontrollerar första if-satsen så är den sann, och går inte vidare till nästa else if-sats.
För att korrigera koden blev age > 18 och age > 50 ombytta så att man först kontrollerar om age är över eller under 50.
Om age är 34, så uppfylls inte age > 50 och då går det vidare till nästa else if-sats, i detta fall age > 30 som uppfylls.
För att be om user input, lades Console.Write till och svaret konverteras från string till en int-variabel som if-satserna kan kontrollera.
