using MaterialSkin;
using MaterialSkin.Controls;

namespace LaboratoryWork2_Oleshko.Forms
{
    public partial class GuidePageForm : MaterialForm
    {
        public GuidePageForm()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.AddFormToManage(this);
        }
    }
}
