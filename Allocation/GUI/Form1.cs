using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        
        //int n_h;
        //int process_id=0;
        int no_process ;
        //segment h;
        //segment p;
        List<segment> holes = new List<segment>();
        List<segment> processes = new List<segment>();


        public Form1()
        {
            InitializeComponent();
            //h = new segment();
            Add_hole.Enabled = false;
            Add_process.Enabled = false;
            allocate.Enabled = false;
            
        }

        void Allocate_First_Fit()
        {
            int m;
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].start == -1)
                {
                    m = search_FF(processes[i].size);
                    if (m >= 0)
                    {
                        processes[i].start = m;
                       
                        draw_tables();
                        allocate.Enabled = true;
                        break;
                        
                    }
                }
            }
        }

            void Sort()
            {
                holes.Sort((x, y) => x.start.CompareTo(y.start));
            }

        int search_FF(int size)
        {
            int t;
            for (int i = 0; i < holes.Count; i++)
            {
                if (size <= holes[i].size)
                {
                    t = holes[i].start;
                    holes[i].start += size;
                    holes[i].size -= size;
                    return t;
                }
            }
            return -1;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



      void draw_tables()
       {
          Free_Table.Rows.Clear();
           Free_Table.Refresh();
           for (int i = 0; i < holes.Count; i++)
           {
               int n = Free_Table.Rows.Add();
               Free_Table.Rows[n].Cells[0].Value = holes[n].start;
               Free_Table.Rows[n].Cells[1].Value = holes[n].size;
           }

          Allocation_Table.Rows.Clear();
          Allocation_Table.Refresh();
          for (int i = 0; i < processes.Count; i++)
          {
              int m = Allocation_Table.Rows.Add();
              Allocation_Table.Rows[m].Cells[0].Value = processes[i].id;
              if (processes[i].start == -1) { Allocation_Table.Rows[m].Cells[1].Value = "none"; }
              else
              { Allocation_Table.Rows[m].Cells[1].Value = processes[i].start; }
              Allocation_Table.Rows[m].Cells[2].Value = processes[i].size;
          }
       }

      

        private void hole_start_TextChanged(object sender, EventArgs e)
        {

        }
        private void hole_size_TextChanged(object sender, EventArgs e)
        {
            Add_hole.Enabled = true;
        }
        private void Add_hole_Click(object sender, EventArgs e)
        {

            int n = Free_Table.Rows.Add();
            holes.Add(new segment() {id=n, name="h",start=int.Parse(hole_start.Text),size = int.Parse(hole_size.Text) });
            Free_Table.Rows[n].Cells[0].Value = holes[n].start;
            Free_Table.Rows[n].Cells[1].Value = holes[n].size;
            Add_hole.Enabled = false;
            hole_start.Clear();
            hole_size.Clear();
            if (Allocation_method.Text == "First fit" || Allocation_method.Text == "Best fit" || Allocation_method.Text == "Worst fit") { allocate.Enabled = true; }
        }
        private void Free_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void number_of_processes_TextChanged(object sender, EventArgs e)
        {
            no_process = int.Parse(number_of_processes.Text);
        }
        private void process_size_TextChanged(object sender, EventArgs e)
        {
            if (no_process != 0) { Add_process.Enabled = true; }
        }
        private void Add_process_Click(object sender, EventArgs e)
        {

            int n = Allocation_Table.Rows.Add();
            processes.Add(new segment() { id = int.Parse(PID.Text), start = -1, size = int.Parse(process_size.Text), name = "P" });
            Allocation_Table.Rows[n].Cells[0].Value = PID.Text;
            Allocation_Table.Rows[n].Cells[1].Value = "none";
            Allocation_Table.Rows[n].Cells[2].Value = process_size.Text;
            Add_process.Enabled = false;
            no_process = int.Parse(number_of_processes.Text);
            number_of_processes.Enabled = false;
            process_size.Clear();
            PID.Clear();
            no_process--;
            if (no_process == 0)
            { Add_process.Enabled = false; }
            if (Allocation_method.Text == "First fit" || Allocation_method.Text == "Best fit" || Allocation_method.Text == "Worst fit") { allocate.Enabled = true; }
        }
        private void Allocation_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void allocate_Best_Fit()
        {
            sort_size();
            Allocate_First_Fit();
        }
        void allocata_Worst_fit()
        {
            sort_size_descending();
            Allocate_First_Fit();
        }
        void sort_size()
        {
            holes.Sort((x, y) => x.size.CompareTo(y.size));
 
        }

        void sort_size_descending()
        {
            holes.Sort((y, x) => x.size.CompareTo(y.size));

        }
        void remove_zero_hole()
        {
            for (int i = 0; i < holes.Count; i++)
            {
                if (holes[i].size == 0)
                {
                    
                    holes.RemoveAt(i);
                }
            }
        }
        private void allocate_Click(object sender, EventArgs e)
        {
            allocate.Enabled = false;
            remove_zero_hole();
            if (Allocation_method.Text == "First fit")
            {
                Sort();
                Allocate_First_Fit();
            }
            else if(Allocation_method.Text == "Best fit")
            {
                allocate_Best_Fit();
            }
            else if (Allocation_method.Text == "Worst fit")
            {
                allocata_Worst_fit();
            }
            remove_zero_hole();
        }

        private void Allocation_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            allocate.Enabled = true;
        }

        void remove_process_by_id(int n)
        {
            for (int i = 0; i < processes.Count; i++)
            {
                if (processes[i].id == n)
                {
                    holes.Add(new segment() { start = processes[i].start, size = processes[i].size, name = "h" });
                    processes.RemoveAt(i); 
                }
            }
        }

        void deallocate()
        { 
            int index;
            index=int.Parse(deallocate_index.Text);
            
            
            
            remove_process_by_id(index);
            Sort();
            add_holes();  
            if (Allocation_method.Text == "Best fit")
            {
                sort_size();
            }
            else if (Allocation_method.Text == "Worst fit")
            {
                sort_size_descending();
            }
            draw_tables();
        }

        void add_holes()
        {
            for (int i = 0; i < holes.Count-1; i++)
            {
                if (holes[i].start + holes[i].size == holes[i + 1].start)
                {
                    holes[i].size += holes[i + 1].size;
                    holes.RemoveAt(i + 1);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            deallocate();
            allocate.Enabled = true;
        }
        
    }
}
            
       
      
    
        
