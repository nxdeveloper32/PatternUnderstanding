Observer Patter (UI Element)
	Acheivement System (when we want to seperate the logic for example when player is dead we dont want to inform acheivent system that player is dead)

	Subject informs observer that something has been changed and then observer does the remaining part of it

Object Pattern (Multiple Type of Weapons having different damage)
	Weapon Management (when there are n number of weapons having different functionality)

	Unity uses prefabs to solve this problem like
		class sword : monobehaviour{
			float damage = 1;
			void attack(Target T){
				T.TakeDamage(damage);
			}
		} //Make a prefab and adjust the damage accordingly

	use scriptable object when we have more than 100 or 1000 weapons

