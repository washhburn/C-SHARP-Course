A15 Logical Error 1

Problemet fanns i rad 18: 
if (numbers[i] < max)

I detta format så räknar man minsta värdet i arrayen. Genom att byta "<" tecknet till ">" istället, så svänger det till max-värdet.
Dvs;
if (numbers[i] > max)

När man nu printar resultatet visas 30 som maxvärde i array.
