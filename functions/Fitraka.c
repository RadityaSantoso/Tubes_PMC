#include "header.c"
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

void format_date(const char* str){
    int len = strlen(str);

    //checker if format 1 or 2 {1 is spaces, 2 is -'s}, default 2
    char delimiter;
    char* checker=strchr(str, '-');
    if(checker==NULL){
        delimiter='-';
    }
    else{
        delimiter=' ';
    }
    //splitting
    char* temp = strchr(str,delimiter);
    char day[5];
    int starting_index=0;
    for(int i=starting_index; i<temp-str;i++){
        day[i-starting_index]=str[i];
    }
    day[temp-str-starting_index]='\0';

    char month[MAX];
    starting_index=temp-str+1;
    temp=strchr(temp+1,delimiter);
    for(int i=starting_index; i<temp-str;i++){
        month[i-starting_index]=str[i];
    }
    month[temp-str-starting_index]='\0';

    char year[5];
    starting_index=temp-str+1;
    for(int i=starting_index; i<strlen(str);i++){
        year[i-starting_index]=str[i];
    }
    year[strlen(str)-starting_index]='\0';


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
        format_date(token);
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


