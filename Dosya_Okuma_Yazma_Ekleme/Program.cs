//Dosya Okuma
StreamReader sr=File.OpenText("deneme.txt");//geri donecek streamreader objemiz
var s="";
while((s=sr.ReadLine())!= null){//s degiseni sr nin dolui her sataruini tutacak
Console.WriteLine(s);//satiri okur

}

string sonuc=File.ReadAllText("deneme.txt");//bu da diger bir yol usteekinde satir satir erismek isterim burda hepsini alirim
Console.WriteLine(sonuc);

string [] degerler=File.ReadAllLines("deneme.txt");//buda tum linelari okuyup alir

for (var i=0; i<degerler.Length; i++){
    Console.WriteLine(degerler[i]);
}

//Dosya Yazma

using (StreamWriter sw=File.CreateText("deneme.txt")//dosyayi yazma modunda aciyoruz bize StreamWriter dondurcek
){
sw.WriteLine("Merhaba");//satirlara yadiriyoruz deneme  txt dosyamiz icinde
sw.WriteLine("Btk");
sw.WriteLine("Akademi");

}
//varolan dosyanin uzerine bilgi ekleme
using (StreamWriter sw=File.AppendText("deneme.txt")//dosyayi ekleme modunda aciyoruz bize StreamWriter dondurcek
){
sw.WriteLine("Selam");//satirlara ekliyoruz deneme  txt dosyamiz icinde
sw.WriteLine("Btk");
sw.WriteLine("Akademi");

}


// File.WriteAllText("deneme.txt", "merhaba"); //dosya yoksa dosyayi acar varsa tum veriyi silip uzerine mesaji yazar
File.AppendAllText("deneme.txt", "yuko"); //dosya yoksa dosyayi acar varsa veriyi uzerine ekler