
Enemy Guard = new Enemy("Guard");

// Guard.ShowInfo();

// Guard.AddAttack(Punch, punch, 5);
Attack Punch = new Attack("Punch", 10);
Guard.AddAttack(Punch);
Attack Kick = new Attack("Kick", 15);
Guard.AddAttack(Kick);
Attack FireBall = new Attack("Fire Ball", 25);
Guard.AddAttack(FireBall);

Guard.ShowInfo();
Guard.RandomAttack();
Guard.ShowHealth();
Guard.RandomAttack();
Guard.ShowHealth();
Guard.RandomAttack();
Guard.ShowHealth();
Guard.RandomAttack();
Guard.ShowHealth();
Guard.RandomAttack();
Guard.ShowHealth();
Guard.RandomAttack();
Guard.ShowHealth();
