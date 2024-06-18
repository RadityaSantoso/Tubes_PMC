#include "functions/header.c"
#include "functions/Adam.c"
#include "functions/Hubert.c"
#include "functions/Fitraka.c"
#include "functions/Raditya.c"
#include "functions/Requint.c"


int main() {
    int ch;
    Riwayat riwayatArray[MAX];
    int count=0;
    char IDpasiensearch[MAX];
    //read Data Pasien
    FILE* file1 = fopen("Data/DataPMC20232024.csv", "r");
    if (file1 == NULL) {
        printf("Error opening file!\n");
        return 1;
    }
    Pasien* head = NULL;
    bacaDataPasien(file1, &head);
    fclose(file1);
    
    //read riwayat pasien
    FILE* file2 = fopen("Data/riwayatpasien.csv", "r");
    if (file2 == NULL) {
        printf("Error opening file!\n");
        return 1;
    }
    fclose(file2);
    readCSV("Data/riwayatpasien.csv", riwayatArray, &count);
    replaceHyphenWithSpace(riwayatArray, count);
    

    // Loop menu utama
    do {
        //gabisa nginput gatau kenapa
        //system("cls");  // Membersihkan layar konsol
        printf("1.  Menambah data pasien\n");
        printf("2.  Mengubah data pasien\n");
        printf("3.  Menghapus data pasien\n");
        printf("4.  Mencari data pasien\n");
        printf("5.  Menambah riwayat diagnosis dan penanganan\n");
        printf("6.  Mengubah riwayat diagnosis dan penanganan\n");
        printf("7.  Menghapus riwayat diagnosis dan penanganan\n");
        printf("8.  Mencari riwayat diagnosis dan penanganan\n");
        printf("9.  Info pasien dan riwayat medisnya\n");
        printf("10. Info pendapatan bulanan, pendapatan tahunan, dan rata-rata pendapatan per tahun\n");
        printf("11. Info jumlah pasien dan penyakitnya\n");
        printf("12. Info untuk kontrol\n");
        printf("\nMasukan pilihan (pilih 0 untuk keluar) : ");
        scanf("%d", &ch);
    switch (ch)
    {
    case 1:
        // Menambah data pasien
        menambah_data_pasien(&head);
        break;
    case 2:
        // Mengubah data pasien
        mengubah_data_pasien(head);
        break;
    case 3:
        //Menghapus data pasien
        menghapus_data_pasian(&head);
        break;
    case 4:
        // Mencari data pasien dan print
        print_pasien(head);
        break;
    case 5:
        // Menambah riwayat diagnosis dan penanganan
        break;
    case 6:
        // Mengubah riwayat diagnosis dan penanganan
        break;
    case 7:
        // Menghapus riwayat diagnosis dan penanganan
        break;
    case 8:
        // Mencari riwayat diagnosis dan penanganan
        break;
    case 9:
        // Memberikan info pasien dan riwayat medisnya kepada petugas medis
        printf("Masukkan ID Pasien yang ingin dicari: ");
        fgets(IDpasiensearch,MAX,stdin);
        fgets(IDpasiensearch,MAX,stdin);
        IDpasiensearch[strlen(IDpasiensearch)-1]='\0';
        //scanf("%[^\n]%*c", idpasiensearch);
        printf("\n");
        searchDataPasien(head, IDpasiensearch);
        searchRiwayat(riwayatArray, count, IDpasiensearch);
        break;
    case 10:
        // Mendapat informasi rata-rata pendapatan per tahun
        riwayatwithtanggal riwayatWithTanggalArray[MAX];
        penghasilan penghasilanArray[MAX];
        penghasilan mergedArray[MAX];
        penghasilantahun penghasilanTahunArray[MAX];
        penghasilantahun mergedTahunArray[MAX];
        int mergedCount, mergedTahunCount;
        char idpasiensearch[MAX];
        getriwayatwithtanggal(riwayatWithTanggalArray, riwayatArray, count);
        add2000ToTahun(riwayatWithTanggalArray, count);
        convertformat(riwayatWithTanggalArray, count, penghasilanArray);
        mergePenghasilan(penghasilanArray, count, mergedArray, &mergedCount);
        sortPenghasilan(mergedArray, mergedCount);
        printTotalBiayaPerBulanTahun(mergedArray, mergedCount);
        fillPenghasilanTahunArray(mergedArray, mergedCount, penghasilanTahunArray, &mergedTahunCount);
        printTotalBiayaPerTahun(penghasilanTahunArray, mergedTahunCount);
        int avgyear = findAverageBiayaPerTahun(penghasilanTahunArray, mergedTahunCount);
        printf("\n");
        printf("Rata-rata pendapatan per tahun adalah %d\n", avgyear);
        break;
    case 11:
        // Mendapat info jumlah pasien dan penyakit yang diderita (sorted)
        PasienTiapWaktu(file2);
        break;
    case 12:
        // Memberikan info untuk kontrol
        break;
    case 0:
        printf("Terima kasih telah menggunakan program ini. Program telah ditutup.\n");
        break;
    default:
        printf("Pilihan tidak valid.\n");
    }
    printf("\n");
    printf("Tekan tombol apapun untuk melanjutkan\n");
    _getch();  // Menunggu input dari user sebelum melanjutkan
    } while (ch != 0);  // Loop terus menerus hingga user memilih keluar (0)
    /*
    int check=0;
    do{
    printf("\nMasukkan nama folder yang akan menyetor file baru.\n");
    char filedir[MAX];
    check = mkdir(filedir);
    if(!check){
        printf("Pembuatan file Berhasil.\n");
    }
    else{
        printf("Pembuatan file Gagal.\n");
    }
    }while(check!=1);
    */
    // Bebaskan memori dari linked list sebelum keluar dari program
    freeList(head);
  return 0;
}