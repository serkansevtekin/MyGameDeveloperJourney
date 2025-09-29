using System;

namespace Programlama.IleriAlgoritma
{
    public class AgacClass
    {
        public static void AgacRunMethod()
        {

        }
    }
    
    #region Ağaç ve İkili Ağaç Tanım
        /*

        *** 1. Ağaç (Tree) Nedir? ***
                    
                - Ağaç, düpümlerden(node) oluşan, hiyerarşik bir veri yapısıdır.
                - En üstte kök(oot) düğüm vardır.
                - Her düğümün 0 veya daha fazla alt düğümü (child) olabilir
                - Alt düğümü olmayan düğümşere yaprak (leaf) denir.
                - Düğümler arasındaki bağlantılara kenar (edge) denir.

            ---* Özellikleri:
                    - Çizge teorisindeki özel bir graf yapısıdır (çevrim içermez)
                    - Genelde hyerarşik yapıları temsil etmek için kullanılır: dosya sistemleri, organizasyon şemaları, oyun ağaçları

        *** 2. İkili Ağaç (Binary Tree)
                
                . Her düğümün en fazla 2 alt düğümü vardır:
                    - Sol çocuk (left child)
                    - Sağ çocuk (right child)
                
                . Boş olabilir (yani sol ve sağ çocuk olmayabilir)
            
            --* Özel Türleri:

                    *-* Full Binary Tree ( Tam İkili Ağaç): Her düğümün ya 0 yada 2 çocuğu vardır

                    *-* Complate Binary Tree (Tamamlanmış İkili Ağaç): Son seviye hariç tüm sevilerer tamamen doludur, son seviye soldan sağa soğru doldurulur.

                    *-* Binary Search Tree, BTS ( İkili arama ağacı ): Sol alt ağaç kökten küçül, sağ alt ağaç kökten büpü değerleri tutar

        *** 3. Ağaç Gzinmeleri (Tree Traversal)

                . Ağaç üzerindeki düpümleri belli bir sıraya göre dolaşmaya "treversal" denir.
                . Trevarsal, Derinlik öncelikli (DFS) ve genişlik öncelikli (BFS) olarak ikiye ayrılır.
            
            A) Derinlik Öncelikli (DFS)

                . İkli ağaçta üç temel yöntem vardır:

                    1. Preorder (Kök - Sol - Sağ)
                        . Önce kök , sonra sol alt ağaç, sora sağ alt ağaç
                        . Kullanım: Ağaç kopyalama, ifade ağacından prefix ifede elde etme.
                        . Örnek Sıralama: A -> B  -> D -> E -> C -> F -> G
                    
                    2. Inorder (Sol - Kök - Sağ)
                        . Önce sol alt ağaç, sonra kök , sonra sağ alt ağaç
                        . Kullanım: İkili arama ağacında sıralı çıktı verir
                        . Örnek Sıralam: D -> B -> E -> A -> F -> C -> G
                    
                    3. Postorder (Sol - Sağ - Kök)
                        . Önce sol, sonra sağ alt ağaç , en son kök
                        . Kullanım: Bellek temizleme, ifade ağacından postfix ifade elde etme
                        . Örnek Sıra D -> E -> B -> F -> G -> C -> A
            
            B) Genişlik Öncelikli (BFS / Level Order)
                
                . Ağaç seviye seviye gezilir (Queue kullanır)
                . Örnek Sıra: A -> B -> C -> D -> E -> F -> G
        */
    #endregion
}