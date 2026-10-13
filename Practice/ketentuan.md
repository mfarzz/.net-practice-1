Ketentuan:
• Input jumlah pelanggan (1-5), lalu nama, golongan (1-3), meter awal (minimal 0), 
dan meter akhir (tidak boleh kurang dari meter awal) tiap pelanggan. Ulang input yang tidak valid.
• Tarif per kWh memakai switch: golongan 1 (900 VA) = 1.350, golongan 2 (1300 VA) = 1.450, golongan 3 (2200 VA) = 1.500.
• Pemakaian = meter akhir - meter awal. Tagihan = pemakaian x tarif.
• Pajak penerangan jalan (PPJ) 3% dari tagihan dan biaya admin 2.500, keduanya const. Total = tagihan + PPJ + admin.
• Kategori pemakaian: di bawah 100 kWh = Hemat, 100-300 kWh = Normal, di atas 300 kWh = Boros.
• Cetak tagihan tiap pelanggan, total tagihan semua pelanggan, dan pelanggan dengan pemakaian terbesar.
• Method minimal: TarifPerKwh(golongan), HitungPpj(tagihan), Kategori(kwh), dan CetakTagihan(...).

Fitur tambahan:
- Pencarian berdasarkan nama pelanggan
- Pembayaran tagihan 