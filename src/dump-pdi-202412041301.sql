PGDMP  0                    |            pdi    16.2    16.2 6    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    50642    pdi    DATABASE     }   CREATE DATABASE pdi WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE pdi;
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false            �           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    4            �            1259    58892    AspNetUserClaims    TABLE     �   CREATE TABLE public."AspNetUserClaims" (
    "Id" integer NOT NULL,
    "UserId" text NOT NULL,
    "ClaimType" text,
    "ClaimValue" text
);
 &   DROP TABLE public."AspNetUserClaims";
       public         heap    postgres    false    4            �            1259    58891    AspNetUserClaims_Id_seq    SEQUENCE     �   ALTER TABLE public."AspNetUserClaims" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."AspNetUserClaims_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    224            �            1259    58904    AspNetUserLogins    TABLE     �   CREATE TABLE public."AspNetUserLogins" (
    "LoginProvider" text NOT NULL,
    "ProviderKey" text NOT NULL,
    "ProviderDisplayName" text,
    "UserId" text NOT NULL
);
 &   DROP TABLE public."AspNetUserLogins";
       public         heap    postgres    false    4            �            1259    58916    AspNetUserTokens    TABLE     �   CREATE TABLE public."AspNetUserTokens" (
    "UserId" text NOT NULL,
    "LoginProvider" text NOT NULL,
    "Name" text NOT NULL,
    "Value" text
);
 &   DROP TABLE public."AspNetUserTokens";
       public         heap    postgres    false    4            �            1259    58860    AspNetUsers    TABLE     f  CREATE TABLE public."AspNetUsers" (
    "Id" text NOT NULL,
    "Role" integer NOT NULL,
    "UserName" character varying(256),
    "NormalizedUserName" character varying(256),
    "Email" character varying(256),
    "NormalizedEmail" character varying(256),
    "EmailConfirmed" boolean NOT NULL,
    "PasswordHash" text,
    "SecurityStamp" text,
    "ConcurrencyStamp" text,
    "PhoneNumber" text,
    "PhoneNumberConfirmed" boolean NOT NULL,
    "TwoFactorEnabled" boolean NOT NULL,
    "LockoutEnd" timestamp with time zone,
    "LockoutEnabled" boolean NOT NULL,
    "AccessFailedCount" integer NOT NULL
);
 !   DROP TABLE public."AspNetUsers";
       public         heap    postgres    false    4            �            1259    58868    Barang    TABLE     �   CREATE TABLE public."Barang" (
    "BarangId" integer NOT NULL,
    "NamaBarang" text NOT NULL,
    "Harga" text NOT NULL,
    "StokAwal" text NOT NULL,
    "Kategori" text NOT NULL,
    "GambarBarang" text NOT NULL
);
    DROP TABLE public."Barang";
       public         heap    postgres    false    4            �            1259    58867    Barang_BarangId_seq    SEQUENCE     �   ALTER TABLE public."Barang" ALTER COLUMN "BarangId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Barang_BarangId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    218    4            �            1259    58876    Kategori    TABLE     h   CREATE TABLE public."Kategori" (
    "KategoriID" integer NOT NULL,
    "NamaKategori" text NOT NULL
);
    DROP TABLE public."Kategori";
       public         heap    postgres    false    4            �            1259    58875    Kategori_KategoriID_seq    SEQUENCE     �   ALTER TABLE public."Kategori" ALTER COLUMN "KategoriID" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Kategori_KategoriID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    220    4            �            1259    58884    Pages    TABLE     q   CREATE TABLE public."Pages" (
    "Id" integer NOT NULL,
    "Title" text,
    "Body" text,
    "Author" text
);
    DROP TABLE public."Pages";
       public         heap    postgres    false    4            �            1259    58883    Pages_Id_seq    SEQUENCE     �   ALTER TABLE public."Pages" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Pages_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    222    4            �            1259    58929 	   Transaksi    TABLE     ,  CREATE TABLE public."Transaksi" (
    "transactionId" integer NOT NULL,
    "BarangId" integer NOT NULL,
    "KategoriID" integer NOT NULL,
    "Hargaitem" integer NOT NULL,
    "Totalharga" integer NOT NULL,
    "JmlItem" integer NOT NULL,
    "transactionDate" timestamp with time zone NOT NULL
);
    DROP TABLE public."Transaksi";
       public         heap    postgres    false    4            �            1259    58928    Transaksi_transactionId_seq    SEQUENCE     �   ALTER TABLE public."Transaksi" ALTER COLUMN "transactionId" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Transaksi_transactionId_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    228            �            1259    58855    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false    4            �          0    58892    AspNetUserClaims 
   TABLE DATA           W   COPY public."AspNetUserClaims" ("Id", "UserId", "ClaimType", "ClaimValue") FROM stdin;
    public          postgres    false    224   �C       �          0    58904    AspNetUserLogins 
   TABLE DATA           m   COPY public."AspNetUserLogins" ("LoginProvider", "ProviderKey", "ProviderDisplayName", "UserId") FROM stdin;
    public          postgres    false    225   �C       �          0    58916    AspNetUserTokens 
   TABLE DATA           X   COPY public."AspNetUserTokens" ("UserId", "LoginProvider", "Name", "Value") FROM stdin;
    public          postgres    false    226   �C       �          0    58860    AspNetUsers 
   TABLE DATA           *  COPY public."AspNetUsers" ("Id", "Role", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount") FROM stdin;
    public          postgres    false    216   �C       �          0    58868    Barang 
   TABLE DATA           m   COPY public."Barang" ("BarangId", "NamaBarang", "Harga", "StokAwal", "Kategori", "GambarBarang") FROM stdin;
    public          postgres    false    218   �D       �          0    58876    Kategori 
   TABLE DATA           B   COPY public."Kategori" ("KategoriID", "NamaKategori") FROM stdin;
    public          postgres    false    220   E       �          0    58884    Pages 
   TABLE DATA           B   COPY public."Pages" ("Id", "Title", "Body", "Author") FROM stdin;
    public          postgres    false    222   ?E       �          0    58929 	   Transaksi 
   TABLE DATA           �   COPY public."Transaksi" ("transactionId", "BarangId", "KategoriID", "Hargaitem", "Totalharga", "JmlItem", "transactionDate") FROM stdin;
    public          postgres    false    228   \E       �          0    58855    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    215   �E       �           0    0    AspNetUserClaims_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."AspNetUserClaims_Id_seq"', 1, false);
          public          postgres    false    223                        0    0    Barang_BarangId_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."Barang_BarangId_seq"', 1, true);
          public          postgres    false    217                       0    0    Kategori_KategoriID_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."Kategori_KategoriID_seq"', 1, true);
          public          postgres    false    219                       0    0    Pages_Id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public."Pages_Id_seq"', 1, false);
          public          postgres    false    221                       0    0    Transaksi_transactionId_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."Transaksi_transactionId_seq"', 1, true);
          public          postgres    false    227            L           2606    58898 $   AspNetUserClaims PK_AspNetUserClaims 
   CONSTRAINT     h   ALTER TABLE ONLY public."AspNetUserClaims"
    ADD CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY ("Id");
 R   ALTER TABLE ONLY public."AspNetUserClaims" DROP CONSTRAINT "PK_AspNetUserClaims";
       public            postgres    false    224            O           2606    58910 $   AspNetUserLogins PK_AspNetUserLogins 
   CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserLogins"
    ADD CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey");
 R   ALTER TABLE ONLY public."AspNetUserLogins" DROP CONSTRAINT "PK_AspNetUserLogins";
       public            postgres    false    225    225            Q           2606    58922 $   AspNetUserTokens PK_AspNetUserTokens 
   CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserTokens"
    ADD CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name");
 R   ALTER TABLE ONLY public."AspNetUserTokens" DROP CONSTRAINT "PK_AspNetUserTokens";
       public            postgres    false    226    226    226            B           2606    58866    AspNetUsers PK_AspNetUsers 
   CONSTRAINT     ^   ALTER TABLE ONLY public."AspNetUsers"
    ADD CONSTRAINT "PK_AspNetUsers" PRIMARY KEY ("Id");
 H   ALTER TABLE ONLY public."AspNetUsers" DROP CONSTRAINT "PK_AspNetUsers";
       public            postgres    false    216            E           2606    58874    Barang PK_Barang 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Barang"
    ADD CONSTRAINT "PK_Barang" PRIMARY KEY ("BarangId");
 >   ALTER TABLE ONLY public."Barang" DROP CONSTRAINT "PK_Barang";
       public            postgres    false    218            G           2606    58882    Kategori PK_Kategori 
   CONSTRAINT     `   ALTER TABLE ONLY public."Kategori"
    ADD CONSTRAINT "PK_Kategori" PRIMARY KEY ("KategoriID");
 B   ALTER TABLE ONLY public."Kategori" DROP CONSTRAINT "PK_Kategori";
       public            postgres    false    220            I           2606    58890    Pages PK_Pages 
   CONSTRAINT     R   ALTER TABLE ONLY public."Pages"
    ADD CONSTRAINT "PK_Pages" PRIMARY KEY ("Id");
 <   ALTER TABLE ONLY public."Pages" DROP CONSTRAINT "PK_Pages";
       public            postgres    false    222            U           2606    58933    Transaksi PK_Transaksi 
   CONSTRAINT     e   ALTER TABLE ONLY public."Transaksi"
    ADD CONSTRAINT "PK_Transaksi" PRIMARY KEY ("transactionId");
 D   ALTER TABLE ONLY public."Transaksi" DROP CONSTRAINT "PK_Transaksi";
       public            postgres    false    228            ?           2606    58859 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    215            @           1259    58946 
   EmailIndex    INDEX     S   CREATE INDEX "EmailIndex" ON public."AspNetUsers" USING btree ("NormalizedEmail");
     DROP INDEX public."EmailIndex";
       public            postgres    false    216            J           1259    58944    IX_AspNetUserClaims_UserId    INDEX     _   CREATE INDEX "IX_AspNetUserClaims_UserId" ON public."AspNetUserClaims" USING btree ("UserId");
 0   DROP INDEX public."IX_AspNetUserClaims_UserId";
       public            postgres    false    224            M           1259    58945    IX_AspNetUserLogins_UserId    INDEX     _   CREATE INDEX "IX_AspNetUserLogins_UserId" ON public."AspNetUserLogins" USING btree ("UserId");
 0   DROP INDEX public."IX_AspNetUserLogins_UserId";
       public            postgres    false    225            R           1259    58948    IX_Transaksi_BarangId    INDEX     U   CREATE INDEX "IX_Transaksi_BarangId" ON public."Transaksi" USING btree ("BarangId");
 +   DROP INDEX public."IX_Transaksi_BarangId";
       public            postgres    false    228            S           1259    58949    IX_Transaksi_KategoriID    INDEX     Y   CREATE INDEX "IX_Transaksi_KategoriID" ON public."Transaksi" USING btree ("KategoriID");
 -   DROP INDEX public."IX_Transaksi_KategoriID";
       public            postgres    false    228            C           1259    58947    UserNameIndex    INDEX     `   CREATE UNIQUE INDEX "UserNameIndex" ON public."AspNetUsers" USING btree ("NormalizedUserName");
 #   DROP INDEX public."UserNameIndex";
       public            postgres    false    216            V           2606    58899 7   AspNetUserClaims FK_AspNetUserClaims_AspNetUsers_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserClaims"
    ADD CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 e   ALTER TABLE ONLY public."AspNetUserClaims" DROP CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId";
       public          postgres    false    224    4674    216            W           2606    58911 7   AspNetUserLogins FK_AspNetUserLogins_AspNetUsers_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserLogins"
    ADD CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 e   ALTER TABLE ONLY public."AspNetUserLogins" DROP CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId";
       public          postgres    false    216    225    4674            X           2606    58923 7   AspNetUserTokens FK_AspNetUserTokens_AspNetUsers_UserId    FK CONSTRAINT     �   ALTER TABLE ONLY public."AspNetUserTokens"
    ADD CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES public."AspNetUsers"("Id") ON DELETE CASCADE;
 e   ALTER TABLE ONLY public."AspNetUserTokens" DROP CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId";
       public          postgres    false    4674    216    226            Y           2606    58934 &   Transaksi FK_Transaksi_Barang_BarangId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Transaksi"
    ADD CONSTRAINT "FK_Transaksi_Barang_BarangId" FOREIGN KEY ("BarangId") REFERENCES public."Barang"("BarangId") ON DELETE CASCADE;
 T   ALTER TABLE ONLY public."Transaksi" DROP CONSTRAINT "FK_Transaksi_Barang_BarangId";
       public          postgres    false    4677    218    228            Z           2606    58939 *   Transaksi FK_Transaksi_Kategori_KategoriID    FK CONSTRAINT     �   ALTER TABLE ONLY public."Transaksi"
    ADD CONSTRAINT "FK_Transaksi_Kategori_KategoriID" FOREIGN KEY ("KategoriID") REFERENCES public."Kategori"("KategoriID") ON DELETE CASCADE;
 X   ALTER TABLE ONLY public."Transaksi" DROP CONSTRAINT "FK_Transaksi_Kategori_KategoriID";
       public          postgres    false    4679    228    220            �      x������ � �      �      x������ � �      �      x������ � �      �   �   x���n�0 D��W*S���6�0���D��Q$��P5�חd.��N3�U�E,]�m�-k2�l�:���a ��y���/�u���f3/��#�3@~�kB�+�=ɋ���1�tN�y�ɱ��W�^��>]��<��<�E��7��x��I��ͫ���nA�����ev�ˏ(
O�E��EڀP������7Z��76��LS�����������i�?�&I�      �   &   x�3�,�/���,N)N�,NLa�XI����� ھ      �      x�3�,NLI,"�=... (�1      �      x������ � �      �   1   x�3�4B3sssNKNsN##]K]C+0�60����� �V�      �   )   x�32021420101150�OJ,J�K��3�3������ �\:     