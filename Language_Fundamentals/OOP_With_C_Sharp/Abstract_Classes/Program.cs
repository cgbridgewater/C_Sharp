//Can not make an instance of an abstract!!
// Animal myAnimal = new Animal(true, "Tweety", "hervibore", 3);
Bird Tweety = new Bird(true, "Tweety", "hervibore", 3); //  // Notice use of BIRD instead of ANIMAL to create instance of the abstract. MUST BE SPECIFIC TO THE CHILD!!


Tweety.MakeNoise();
Tweety.ShowInfo();