int umur = 16;
string name= "Fadhil";
float height = 1.69f;
string goldar = "O";
bool isSchoolStudent = true;

Console.WriteLine("==Kartu Identitas==");
Console.WriteLine("Nama             :" + name);
Console.WriteLine("Umur             :" + umur);
Console.WriteLine("Tinggi badan     :" + height + " m");
Console.WriteLine("Gol.Darah        :" + goldar);
Console.WriteLine("Masih Sekolah    :" + isSchoolStudent);
Console.WriteLine("");

string Code = "KOP-014";
string namabarang = "Buku Tulis 58 Lembar";
int harga = 3500;
int stok = 120;
bool isReady = true;

Console.WriteLine("+-----------------------------------------------+");
Console.WriteLine($"| {Code}                                       |");
Console.WriteLine($"| {namabarang}                          |");
Console.WriteLine($"| Harga : Rp{harga:N0} /pcs                          |");
Console.WriteLine($"| Stok : {stok}pcs                                 |");
Console.WriteLine($"| Siap Dikirim : {isReady}                           |");
Console.WriteLine("+-----------------------------------------------+");
Console.WriteLine("");

double nilairapor = 87.6666;
double persenkehadiran =0.9375;
int Jumlahbuku = 1250000;

Console.WriteLine("Nilai Rapor          : " + nilairapor.ToString("F2"));
Console.WriteLine("Persentase Kehadiran : " + persenkehadiran.ToString("P2"));
Console.WriteLine("Jumlah Buku          : " + Jumlahbuku.ToString("N0") + " eksemplar");
