using Adv05;

var magazine = new WeaponMagazine(5);
Console.WriteLine
    ($"Is loaded?: {magazine.IsLoaded()}");

magazine.LoadBullet("Ladi");
magazine.LoadBullet("Vjerra");
magazine.LoadBullet("Kunata");
magazine.LoadBullet("Zyshen e kimise");
magazine.LoadBullet("Zyshen e Edenit");
magazine.LoadBullet("Rezerve");

Console.WriteLine
    ($"Is loaded?: {magazine.IsLoaded()}");

magazine.Shoot();
magazine.Shoot();
magazine.Shoot();
magazine.Shoot();
magazine.Shoot();
magazine.Shoot();
