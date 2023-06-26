using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame
{
    internal class Algorithm
    {
        TrangThai bandau;
        TrangThai dich;
        static int[] genX = { -1, 1, 0, 0 };
        static int[] genY = { 0, 0, 1, -1 };
        int n;
        public Algorithm(int[,] current_state, int[,]finish_state, int n,int x, int y)
        {
            this.bandau = new TrangThai();
            this.dich = new TrangThai();

            this.bandau.trangthai = current_state;
            this.dich.trangthai = finish_state;
            
            this.n = n;
            
            bandau.x= x;
            bandau.y= y;

            bandau.Tinh_h(dich);
            bandau.g = 0;
            bandau.f = bandau.g + bandau.h;

        }
        private void tinh_h(TrangThai current, TrangThai finish)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++) {
                    if (current.trangthai[i,j]!=0)
                    {
                        for(int a = 0; a < n; a ++)
                        {   
                            bool checked_ = false;
                            for(int b = 0; b <n; b ++)
                            {
                                if (finish.trangthai[a,b] == current.trangthai[i,j])
                                {
                                    current.h += (Math.Abs(a - i) + Math.Abs(b - j));
                                    checked_ = true;
                                    break;
                                }
                            }
                            if(checked_)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
        internal List<Tuple<int[,],int,int>> A_Sao()
        {
            List<TrangThai> open = new List<TrangThai>();
            List<TrangThai> close = new List<TrangThai>();
            open.Add(this.bandau);
            TrangThai loigiai= new TrangThai();
            while(open.Count > 0)
            {
                //sắp xếp tăng dần độ sai của các trạng thái
                open.Sort((t1, t2) => t1.f.CompareTo(t2.f));
                
                //lấy trạng thái ít sai nhất làm trạng thái cha
                TrangThai cha = open.First();

                //loại bỏ trạng thái đó ra khỏi list con
                open.RemoveAt(0);

                close.Add(cha);

                //thuật toán kết thúc khi cha là lời giải
                if(is_equal(cha.trangthai,dich.trangthai)) {
                    loigiai = cha;
                    break;
                }
                List<TrangThai>CacConCuaCha = new List<TrangThai> ();
                sinhcon(cha, CacConCuaCha);
                TrangThai min = CacConCuaCha[0];

                foreach (TrangThai con in CacConCuaCha)
                {
                    if (!exist_in(con, open) && !exist_in(con, close))
                    {
                        open.Add(con);
                    }

                }
            }

            List<Tuple<int[,],int,int>> ans = new List<Tuple<int[,], int, int>>();
            while(loigiai != null)
            {
                ans.Add( new Tuple<int[,],int,int>(loigiai.trangthai,loigiai.x,loigiai.y));
                loigiai = loigiai.father;
            }
            return ans;
            ///////////////////////////////////
            ///xử lý ans
        }
        
        private bool is_equal(int[,]a, int[,] b)
        {
            return a.Cast<int>().SequenceEqual(b.Cast<int>());
        }

        private void sinhcon(TrangThai Cha,List<TrangThai>CacConCuaCha)
        {
            //thử 4 nước đi, một cha sẽ có nhiều nhất 3 con, vì 1 đứa còn lại chính là ông nội
            for(int i = 0; i < 4; i ++)
            {
                //lấy nước đi tiếp theo
                int x = Cha.x + genX[i];
                int y = Cha.y + genY[i];

                //nếu nước đi hợp lệ
                if(x >= 0 && y >= 0 && x<n && y<n) {
                    //nếu nước đi đó không lặp lại nước cũ
                    if ((Cha.father != null && (x != Cha.father.x || y != Cha.father.y)) || Cha.father == null)
                    {
                        TrangThai con = new TrangThai();
                        con.trangthai = (int[,])Cha.trangthai.Clone();
                        con.x = x;
                        con.y = y;
                        move_0(con,Cha.x,Cha.y);

                        con.Tinh_h(dich);
                        con.g = Cha.g + 1;
                        con.f = con.h + con.g ;
                        con.father = Cha;
                        CacConCuaCha.Add(con);
                    }

                }
            }
        }
        private void move_0(TrangThai con, int cha_x, int cha_y)
        {
            con.trangthai[cha_x,cha_y] = con.trangthai[con.x,con.y];
            con.trangthai[con.x, con.y] = 0;
        }

        private bool exist_in(TrangThai con, List<TrangThai>lst)
        {
            foreach(TrangThai t in lst)
            {
                if (con.trangthai.Cast<int>().SequenceEqual(t.trangthai.Cast<int>()))
                {
                    return true;
                }
            }
            return false;
        }
        private void print(int[,]arr)
        {
            for(int i = 0; i < n; i ++)
            {
                for(int j = 0; j < n; j ++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
