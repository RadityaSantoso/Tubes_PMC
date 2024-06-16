#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>

#define MAX 50 //gue ganti biar strukt data lebih kecil
#define MAX_LINE 500

// Definisikan struktur Riwayat untuk data riwayat
typedef struct Riwayat
{
    char tanggal[MAX];
    char id_pasien[MAX];
    char diagnosis[MAX];
    char tindakan[MAX];
    char kontrol[MAX];
    int biaya;
}Riwayat;

// Definisikan struktur Biaya untuk data biaya
typedef struct Biaya
{
    char aktivitas[MAX];
    int biaya;
}Biaya;

// Definisikan struktur Pasien untuk data pasien
typedef struct Pasien {
    char nama_lengkap[MAX];
    char alamat[MAX];
    char kota[MAX];
    char tempat_lahir[MAX];
    char tanggal_lahir[MAX];
    int umur;
    char no_bpjs[MAX];
    char id_pasien[MAX];
    struct Pasien* next;
} Pasien;
