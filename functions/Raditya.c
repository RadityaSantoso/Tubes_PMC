void remove_string_end_line(char str[MAX]){
    if(str[strlen(str)-1]=='\n'){
        str[strlen(str)-1]='\0';
    }
}
Pasien* cari_data_pasien(Pasien* head, char nama_pasien[MAX]){
    remove_string_end_line(nama_pasien);
    if (head==NULL){
        printf("Data kosong\n");
        return NULL;
    }
    Pasien* temp=head;
    while(temp!=NULL){
        if(strcmp(temp->nama_lengkap, nama_pasien)==0){
            return temp;
        }
        temp=temp->next;
    }
    return NULL;
}


void input_data_pasien_baru(Pasien* pasien){
    char temp_string[MAX];
    int temp_int;    
    printf("\nMasukkan nama baru pasien: ");
    fgets(temp_string,MAX,stdin);
    if(temp_string[0]=='\n'||temp_string[0]=='\0'){ //error checker dengan fgets
        fgets(temp_string,MAX,stdin);
    }
    remove_string_end_line(temp_string);
    strcpy(pasien->nama_lengkap,temp_string);
    printf("Masukkan alamat baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->alamat,temp_string);
    printf("Masukkan kota baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->kota,temp_string);
    printf("Masukkan tempat lahir baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->tempat_lahir,temp_string); 
    printf("Masukkan tanggal lahir baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->tanggal_lahir,temp_string);
    printf("Masukkan umur baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    temp_int=atoi(temp_string);
    pasien->umur=temp_int;
    printf("Masukkan nomor BPJS baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->no_bpjs,temp_string);
    printf("Masukkan id baru pasien: ");
    fgets(temp_string,MAX,stdin);
    remove_string_end_line(temp_string);
    strcpy(pasien->id_pasien,temp_string); 
}

void mengubah_data_pasien(Pasien* head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);
    if(nama_pasien[0]=='\n'||nama_pasien[0]=='\0'){ //error checker dengan fgets
        fgets(nama_pasien,MAX,stdin);
    }

    //Pencarian
    Pasien* pasien = cari_data_pasien(head, nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }

    //Pengubahan
    input_data_pasien_baru(pasien);
}

void menambah_data_pasien(Pasien** head){
    //Penambahan (pada akhir csv)
    if(*head==NULL){
        Pasien* temp = malloc(sizeof(Pasien));
        input_data_pasien_baru(temp);
        temp->next=NULL;
        *head=temp;
        return;
    }
    Pasien* temp = *head;
    while(temp->next!=NULL){
        temp=temp->next;
    }
    temp->next=malloc(sizeof(Pasien));
    input_data_pasien_baru(temp);
    temp->next->next=NULL;
    return;
}

void menghapus_data_pasian(Pasien** head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);
    if(nama_pasien[0]=='\n'||nama_pasien[0]=='\0'){ //error checker dengan fgets
        fgets(nama_pasien,MAX,stdin);
    }

    //Pencarian
    Pasien* pasien = cari_data_pasien(*head, nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }

    //Penghapusan
    if(*head==pasien){
        *head=pasien->next;
        free(pasien);
        printf("Penghapusan pasien %s berhasil.", nama_pasien);
        return;
    }
    Pasien* temp=*head;
    while(temp->next!=pasien){
        temp=temp->next;
    }
    temp->next=pasien->next;
    free(pasien);
    printf("Penghapusan pasien %s berhasil.", nama_pasien);
    return;
}

void print_pasien(Pasien* head){
    //Input nama pasien
    char nama_pasien[MAX];
    printf("Masukkan nama lengkap pasien: ");
    fgets(nama_pasien,MAX,stdin);
    if(nama_pasien[0]=='\n'||nama_pasien[0]=='\0'){ //error checker dengan fgets
        fgets(nama_pasien,MAX,stdin);
    }

    //Pencarian
    Pasien* pasien = cari_data_pasien(head,nama_pasien);
    if(pasien==NULL){
        printf("Pasien tidak ditemukan pada Data.\n");
        return;
    }

    printf("Pasien:\n\nNama Lengkap: %s\nAlamat: %s\nKota: %s\nTempat Lahir: %s\nTanggal Lahir: %s\nUmur: %d\nNo. BPJS: %s\nID Pasien:%s\n\n"
            ,pasien->nama_lengkap,pasien->alamat,pasien->kota,pasien->tempat_lahir,pasien->tanggal_lahir,pasien->umur,pasien->no_bpjs,pasien->id_pasien);
    
}