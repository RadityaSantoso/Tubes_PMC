
//#include "header.c"
// Fungsi untuk membuat node baru untuk pasien
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
/*
// Fungsi untuk membaca file biaya tindakan dan mengisi linked list
Biaya* bacaBiayaFile(const char* filename) {
    FILE* file = fopen(filename, "r");
    if (!file) {
        perror("Gagal membuka file");
        return NULL;
    }

    char line[MAX_LINE];
    Biaya* head = NULL;
    Biaya* current = NULL;

    // Lewati header
    fgets(line, MAX_LINE, file);

    while (fgets(line, MAX_LINE, file)) {
        Biaya* newNode = (Biaya*)malloc(sizeof(Biaya));
        sscanf(line, "%d,%49[^,],\"%d", &newNode->no, newNode->aktivitas, &newNode->biaya);
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

// Fungsi untuk membaca file riwayat pasien dan mengisi linked list
Riwayat* bacaRiwayatPasienFile(const char* filename) {
    FILE* file = fopen(filename, "r");
    if (!file) {
        perror("Gagal membuka file");
        return NULL;
    }

    char line[MAX_LINE];
    Riwayat* head = NULL;
    Riwayat* current = NULL;

    // Lewati header
    fgets(line, MAX_LINE, file);

    while (fgets(line, MAX_LINE, file)) {
        Riwayat* newNode = (Riwayat*)malloc(sizeof(Riwayat));
        sscanf(line, "%d,%49[^,],%19[^,],%49[^,],%49[^,],%49[^,],%d",
               &newNode->no, newNode->tanggal, newNode->idPasien, newNode->diagnosis, newNode->tindakan, newNode->kontrol, &newNode->biaya);
        
        
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

void tambahRiwayatPasien(Riwayat** head) {
    Riwayat* newNode = (Riwayat*)malloc(sizeof(Riwayat));
    printf("Masukkan nomor riwayat: ");
    scanf("%d", &newNode->no);
    getchar(); // Consumes the newline character left in the input buffer by scanf

    printf("Masukkan tanggal (format DD MMM YYYY): ");
    fgets(newNode->tanggal, sizeof(newNode->tanggal), stdin);
    newNode->tanggal[strcspn(newNode->tanggal, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan ID Pasien: ");
    fgets(newNode->idPasien, sizeof(newNode->idPasien), stdin);
    newNode->idPasien[strcspn(newNode->idPasien, "\n")] = '\0'; // Remove newline character if present

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
        Riwayat* current = *head;
        while (current->next != NULL) {
            current = current->next;
        }
        current->next = newNode;
    }
}

// Fungsi untuk mencari riwayat pasien berdasarkan ID Pasien dan tanggal
void cariRiwayatPasien(Riwayat* head) {
    char idPasien[20];
    char tanggal[50];

    printf("Masukkan ID Pasien: ");
    fgets(idPasien, sizeof(idPasien), stdin);
    fgets(idPasien, sizeof(idPasien), stdin);
    idPasien[strcspn(idPasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal (format DD MMM YYYY): ");
    fgets(tanggal, sizeof(tanggal), stdin);
    tanggal[strcspn(tanggal, "\n")] = '\0'; // Remove newline character if present

    Riwayat* current = head;
    bool found = false;

    while (current != NULL) {
        if (strcmp(current->idPasien, idPasien) == 0 && strcmp(current->tanggal, tanggal) == 0) {
            found = true;
            printf("No: %d, Tanggal: %s, ID Pasien: %s, Diagnosis: %s, Tindakan: %s, Kontrol: %s, Biaya: %d\n",
                   current->no, current->tanggal, current->idPasien, current->diagnosis, current->tindakan, current->kontrol, current->biaya);
        }
        current = current->next;
    }

    if (!found) {
        printf("Riwayat pasien dengan ID Pasien %s pada tanggal %s tidak ditemukan.\n", idPasien, tanggal);
    }
}

void hapusRiwayatPasien(Riwayat** head) {
    char idPasien[20];
    char tanggal[50];

    printf("Masukkan ID Pasien untuk menghapus riwayat: ");
    fgets(idPasien, sizeof(idPasien), stdin);
    fgets(idPasien, sizeof(idPasien), stdin);
    idPasien[strcspn(idPasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal riwayat (format DD MMM YYYY): ");
    fgets(tanggal, sizeof(tanggal), stdin);
    tanggal[strcspn(tanggal, "\n")] = '\0'; // Remove newline character if present
    
    Riwayat* current = *head;
    Riwayat* prev = NULL;
    bool found = false;

    while (current != NULL) {
        if (strcmp(current->idPasien, idPasien) == 0 && strcmp(current->tanggal, tanggal) == 0) {
            found = true;
            if (prev == NULL) {
                *head = current->next;
            } else {
                prev->next = current->next;
            }
            free(current);
            printf("Riwayat pasien dengan ID Pasien %s pada tanggal %s berhasil dihapus.\n", idPasien, tanggal);
            break;
        }
        prev = current;
        current = current->next;
    }

    if (!found) {
        printf("Riwayat pasien dengan ID Pasien %s pada tanggal %s tidak ditemukan.\n", idPasien, tanggal);
    }
}


void ubahRiwayatPasien(Riwayat* head) {
    char idPasien[20];
    char tanggal[20];

    printf("Masukkan ID Pasien yang ingin diubah: ");
    fgets(idPasien, sizeof(idPasien), stdin);
    fgets(idPasien, sizeof(idPasien), stdin);
    idPasien[strcspn(idPasien, "\n")] = '\0'; // Remove newline character if present

    printf("Masukkan tanggal riwayat: ");
    fgets(tanggal, sizeof(tanggal), stdin);
    tanggal[strcspn(tanggal, "\n")] = '\0'; // Remove newline character if present

    Riwayat* current = head;
    bool found = false;

    while (current != NULL) {
        if (strcmp(current->idPasien, idPasien) == 0 && strcmp(current->tanggal, tanggal) == 0) {
            found = true;

            // Mengubah data riwayat pasien
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

            printf("Riwayat pasien dengan ID Pasien %s dan tanggal %s telah diubah.\n", idPasien, tanggal);
            break;
        }
        current = current->next;
    }

    if (!found) {
        printf("Riwayat pasien dengan ID Pasien %s dan tanggal %s tidak ditemukan.\n", idPasien, tanggal);
    }
}

/*
 case 5:
    tambahRiwayatPasien(&riwayatPasienHead);
    break;
case 6:
    cariRiwayatPasien(riwayatPasienHead);
    break;
case 7:
    hapusRiwayatPasien(&riwayatPasienHead);
    break;
case 8:
    ubahRiwayatPasien(riwayatPasienHead);
    break;
*/

