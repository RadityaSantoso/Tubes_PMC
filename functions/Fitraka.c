

// Fungsi untuk membuat node baru untuk pasien
typedef struct Biaya2 {
    int no;
    char aktivitas[MAX];
    int biaya;
    struct Biaya2* next;
} Biaya2;

typedef struct Riwayat2 {
    int no;
    char tanggal[MAX];
    char id_pasien[MAX];
    char diagnosis[MAX];
    char tindakan[MAX];
    char kontrol[MAX];
    int biaya;
    struct Riwayat2* next;
} Riwayat2;

Pasien* createPasien(char* nama_lengkap, char* alamat, char* kota, char* tempat_lahir, char* tanggal_lahir, int umur, char* no_bpjs, char* id_pasien) {
    Pasien* newPasien = (Pasien*)malloc(sizeof(Pasien));
    strcpy(newPasien->nama_lengkap, nama_lengkap);
    strcpy(newPasien->alamat, alamat);
    strcpy(newPasien->kota, kota);
    strcpy(newPasien->tempat_lahir, tempat_lahir);
    strcpy(newPasien->tanggal_lahir, tanggal_lahir);
    newPasien->umur = umur;
    strcpy(newPasien->no_bpjs, no_bpjs);
    strcpy(newPasien->id_pasien, id_pasien);
    newPasien->next = NULL;
    return newPasien;
}

// Fungsi untuk menyisipkan pasien baru ke dalam linked list
void insertPasien(Pasien** head, Pasien* newPasien) {
    if (*head == NULL) {
        *head = newPasien;
    } else {
        Pasien* temp = *head;
        while (temp->next != NULL) {
            temp = temp->next;
        }
        temp->next = newPasien;
    }
}

// Fungsi untuk membebaskan memori dari linked list
void freeList(Pasien* head) {
    //
    Pasien* temp;
    while (head != NULL) {
        temp = head;
        head = head->next;
        free(temp);
    }
}

void bacaDataPasien(FILE* file, Pasien** head) {
    char line[MAX_LINE];
    fgets(line,sizeof(line), file); //Gw nambah ini biar skip first line -Adit
    while (fgets(line, sizeof(line), file)) {
        int no, umur;
        char nama_lengkap[MAX], alamat[MAX], kota[MAX], tempat_lahir[MAX], tanggal_lahir[MAX], no_bpjs[MAX], id_pasien[MAX];

        char* pos;
        if ((pos = strchr(line, '\n')) != NULL) {
            *pos = '\0';
        }
        if ((pos = strchr(line, '\r')) != NULL) {
            *pos = '\0';
        }

        char* token = strtok(line, "\",\"");
        no = atoi(token);

        token = strtok(NULL, "\",\"");
        strcpy(nama_lengkap, token);

        token = strtok(NULL, "\",\"");
        strcpy(alamat, token);

        token = strtok(NULL, "\",\"");
        strcpy(kota, token);
        token = strtok(NULL, "\",\"");
        strcpy(tempat_lahir, token);

        token = strtok(NULL, "\",\"");
        strcpy(tanggal_lahir, token);

        token = strtok(NULL, "\",\"");
        umur = atoi(token);

        token = strtok(NULL, "\",\"");
        strcpy(no_bpjs, token);

        token = strtok(NULL, "\",\"\n");
        strcpy(id_pasien, token);

        Pasien* newPasien = createPasien(nama_lengkap, alamat, kota, tempat_lahir, tanggal_lahir, umur, no_bpjs, id_pasien);
        insertPasien(head, newPasien);
    }
}

// Fungsi untuk membaca file Riwayat2 pasien dan mengisi linked list
Riwayat2* bacaRiwayat2PasienFile(const char* filename) {
    FILE* file = fopen(filename, "r");
    if (!file) {
        perror("Gagal membuka file");
        return NULL;
    }

    char line[MAX_LINE];
    Riwayat2* head = NULL;
    Riwayat2* current = NULL;

    // Lewati header
    fgets(line, MAX_LINE, file);

    while (fgets(line, MAX_LINE, file)) {
        Riwayat2* newNode = (Riwayat2*)malloc(sizeof(Riwayat2));
        sscanf(line, "%d,%49[^,],%19[^,],%49[^,],%49[^,],%49[^,],%d",
               &newNode->no, newNode->tanggal, newNode->id_pasien, newNode->diagnosis, newNode->tindakan, newNode->kontrol, &newNode->biaya);
        
        
        newNode->next = NULL;

        if (head == NULL) {
            head = newNode;
            current = head;
        } else {
            current->next = newNode;
            current = current->next;
        }
    }

    fclose(file);
    return head;
}

void tambahRiwayat2Pasien(Riwayat2** head) {
    Riwayat2* newNode = (Riwayat2*)malloc(sizeof(Riwayat2));
    printf("Masukkan nomor Riwayat2: ");
    scanf("%d", &newNode->no);
    getchar(); // Consumes the newline character left in the input buffer by scanf

    printf("Masukkan tanggal (format DD MMM YYYY): ");
    fgets(newNode->tanggal, sizeof(newNode->tanggal), stdin);
    newNode->tanggal[strcspn(newNode->tanggal, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan ID Pasien: ");
    fgets(newNode->id_pasien, sizeof(newNode->id_pasien), stdin);
    newNode->id_pasien[strcspn(newNode->id_pasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan diagnosis: ");
    fgets(newNode->diagnosis, sizeof(newNode->diagnosis), stdin);
    newNode->diagnosis[strcspn(newNode->diagnosis, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tindakan: ");
    fgets(newNode->tindakan, sizeof(newNode->tindakan), stdin);
    newNode->tindakan[strcspn(newNode->tindakan, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal kontrol (format DD MMM YYYY): ");
    fgets(newNode->kontrol, sizeof(newNode->kontrol), stdin);
    newNode->kontrol[strcspn(newNode->kontrol, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan biaya: ");
    scanf("%d", &newNode->biaya);
    getchar(); // Consumes the newline character left in the input buffer by scanf

    // convertDateFormat(newNode->tanggal);  // Convert date format
    // convertDateFormat(newNode->kontrol);  // Convert control date format

    newNode->next = NULL;

    if (*head == NULL) {
        *head = newNode;
    } else {
        Riwayat2* current = *head;
        while (current->next != NULL) {
            current = current->next;
        }
        current->next = newNode;
    }
}

// Fungsi untuk mencari Riwayat2 pasien berdasarkan ID Pasien dan tanggal
void cariRiwayat2Pasien(Riwayat2* head) {
    char id_pasien[20];
    char tanggal[50];

    printf("Masukkan ID Pasien: ");
    fgets(id_pasien, sizeof(id_pasien), stdin);
    fgets(id_pasien, sizeof(id_pasien), stdin);
    id_pasien[strcspn(id_pasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal (format DD MMM YYYY): ");
    fgets(tanggal, sizeof(tanggal), stdin);
    tanggal[strcspn(tanggal, "\n")] = '\0'; // Remove newline character if present

    Riwayat2* current = head;
    bool found = false;

    while (current != NULL) {
        if (strcmp(current->id_pasien, id_pasien) == 0 && strcmp(current->tanggal, tanggal) == 0) {
            found = true;
            printf("No: %d, Tanggal: %s, ID Pasien: %s, Diagnosis: %s, Tindakan: %s, Kontrol: %s, Biaya: %d\n",
                   current->no, current->tanggal, current->id_pasien, current->diagnosis, current->tindakan, current->kontrol, current->biaya);
        }
        current = current->next;
    }

    if (!found) {
        printf("Riwayat2 pasien dengan ID Pasien %s pada tanggal %s tidak ditemukan.\n", id_pasien, tanggal);
    }
}

void hapusRiwayat2Pasien(Riwayat2** head) {
    char id_pasien[20];
    char tanggal[50];

    printf("Masukkan ID Pasien untuk menghapus Riwayat: ");
    fgets(id_pasien, sizeof(id_pasien), stdin);
    fgets(id_pasien, sizeof(id_pasien), stdin);
    id_pasien[strcspn(id_pasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal Riwayat (format DD MMM YYYY): ");
    fgets(tanggal, sizeof(tanggal), stdin);
    tanggal[strcspn(tanggal, "\n")] = '\0'; // Remove newline character if present
    
    Riwayat2* current = *head;
    Riwayat2* prev = NULL;
    bool found = false;

    while (current != NULL) {
        if (strcmp(current->id_pasien, id_pasien) == 0 && strcmp(current->tanggal, tanggal) == 0) {
            found = true;
            if (prev == NULL) {
                *head = current->next;
            } else {
                prev->next = current->next;
            }
            free(current);
            printf("Riwayat2 pasien dengan ID Pasien %s pada tanggal %s berhasil dihapus.\n", id_pasien, tanggal);
            break;
        }
        prev = current;
        current = current->next;
    }

    if (!found) {
        printf("Riwayat2 pasien dengan ID Pasien %s pada tanggal %s tidak ditemukan.\n", id_pasien, tanggal);
    }
}


void ubahRiwayat2Pasien(Riwayat2* head) {
    char id_pasien[20];
    char tanggal[20];

    printf("Masukkan ID Pasien yang ingin diubah: ");
    fgets(id_pasien, sizeof(id_pasien), stdin);
    fgets(id_pasien, sizeof(id_pasien), stdin);
    id_pasien[strcspn(id_pasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal Riwayat: ");
    fgets(tanggal, sizeof(tanggal), stdin);
    tanggal[strcspn(tanggal, "\n")] = '\0'; // Remove newline character if present

    Riwayat2* current = head;
    bool found = false;

    while (current != NULL) {
        if (strcmp(current->id_pasien, id_pasien) == 0 && strcmp(current->tanggal, tanggal) == 0) {
            found = true;

            // Mengubah data Riwayat2 pasien
            printf("Masukkan tanggal: ");
            fgets(current->tanggal, sizeof(current->tanggal), stdin);
            fgets(current->tanggal, sizeof(current->tanggal), stdin);
            current->tanggal[strcspn(current->tanggal, "\n")] = '\0'; // Remove newline character if present
            
            printf("Masukkan diagnosis: ");
            fgets(current->diagnosis, sizeof(current->diagnosis), stdin);
            current->diagnosis[strcspn(current->diagnosis, "\n")] = '\0'; // Remove newline character if present
            
            printf("Masukkan tindakan: ");
            fgets(current->tindakan, sizeof(current->tindakan), stdin);
            current->tindakan[strcspn(current->tindakan, "\n")] = '\0'; // Remove newline character if present
            
            printf("Masukkan tanggal kontrol (format DD-MMM-YY): ");
            fgets(current->kontrol, sizeof(current->kontrol), stdin);
            current->kontrol[strcspn(current->kontrol, "\n")] = '\0'; // Remove newline character if present

            printf("Masukkan biaya: ");
            scanf("%d", &current->biaya);

            printf("Riwayat pasien dengan ID Pasien %s dan tanggal %s telah diubah.\n", id_pasien, tanggal);
            break;
        }
        current = current->next;
    }

    if (!found) {
        printf("Riwayat pasien dengan ID Pasien %s dan tanggal %s tidak ditemukan.\n", id_pasien, tanggal);
    }
}

// Fungsi untuk menyimpan linked list Riwayat2 pasien ke file
void simpanRiwayat2PasienKeFile(Riwayat2* head, const char* filename) {
    FILE* file = fopen(filename, "w");
    if (!file) {
        perror("Gagal membuka file");
        return;
    }

    fprintf(file, "No,Tanggal,ID Pasien,Diagnosis,Tindakan,Kontrol,Biaya\n");

    Riwayat2* current = head;
    while (current != NULL) {
        fprintf(file, "%d,%s,%s,%s,%s,%s,%d\n",
                current->no, current->tanggal, current->id_pasien, current->diagnosis,
                current->tindakan, current->kontrol, current->biaya);
        current = current->next;
    }

    fclose(file);
}
/*
 case 5:
    tambahRiwayat2Pasien(&Riwayat2PasienHead);
    break;
case 6:
    cariRiwayat2Pasien(Riwayat2PasienHead);
    break;
case 7:
    hapusRiwayat2Pasien(&Riwayat2PasienHead);
    break;
case 8:
    ubahRiwayat2Pasien(Riwayat2PasienHead);
    break;
case 0:
    simpanRiwayat2PasienKeFile(Riwayat2PasienHead, "Riwayat2pasien2.csv");
    return 0;
*/

