// [예제 변경] 네임스페이스: G26W09WFSnackList -> G26HW01WorkoutLog
namespace G26HW01WorkoutLog {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            mainContainer = new ListBox();
            titleField = new TextBox();
            descField = new TextBox();
            linkField = new TextBox();
            submitAction = new Button();
            imageRenderer = new PictureBox();
            filterText = new TextBox();
            dropAction = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.FormattingEnabled = true;
            mainContainer.HorizontalScrollbar = true;
            mainContainer.Location = new Point(12, 47);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(658, 229);
            mainContainer.TabIndex = 9;
            mainContainer.SelectedIndexChanged += ShowImage;
            // 
            // titleField
            // 
            titleField.Location = new Point(5, 25);
            titleField.Name = "titleField";
            // [예제 변경] 입력 안내: 추가할 야식 메뉴 -> 운동 이름
            titleField.PlaceholderText = "운동 이름 (예: 바벨 스쿼트)";
            titleField.Size = new Size(231, 31);
            titleField.TabIndex = 0;
            // 
            // descField
            // 
            descField.Location = new Point(242, 25);
            descField.Name = "descField";
            // [예제 변경] 입력 안내: 스트레스 원인 또는 평가 -> 세트·무게·시간 메모
            descField.PlaceholderText = "기록 메모 (예: 5x5 80kg / 30분 5km)";
            descField.Size = new Size(231, 31);
            descField.TabIndex = 4;
            // 
            // linkField
            // 
            linkField.Location = new Point(479, 25);
            linkField.Name = "linkField";
            // [예제 변경] 입력 안내: 음식 사진 웹 URL -> 운동 사진 웹 URL
            linkField.PlaceholderText = "운동 사진 웹 URL (선택)";
            linkField.Size = new Size(231, 31);
            linkField.TabIndex = 5;
            // 
            // submitAction
            // 
            submitAction.Location = new Point(716, 23);
            submitAction.Name = "submitAction";
            submitAction.Size = new Size(231, 35);
            submitAction.TabIndex = 6;
            // [예제 변경] 버튼 글자와 연결 핸들러: 야식 추가/InsertSnack -> 기록 추가/InsertWorkout
            submitAction.Text = "기록 추가";
            submitAction.Click += InsertWorkout;
            // 
            // imageRenderer
            // 
            imageRenderer.BorderStyle = BorderStyle.FixedSingle;
            imageRenderer.Location = new Point(676, 12);
            imageRenderer.Name = "imageRenderer";
            imageRenderer.Size = new Size(310, 310);
            imageRenderer.SizeMode = PictureBoxSizeMode.Zoom;
            imageRenderer.TabIndex = 11;
            imageRenderer.TabStop = false;
            // 
            // filterText
            // 
            filterText.Location = new Point(12, 12);
            filterText.Name = "filterText";
            // [예제 변경] 검색 안내: 야식 또는 원인/평가 검색 -> 운동 이름 또는 메모 검색
            filterText.PlaceholderText = "운동 이름 또는 메모 검색";
            filterText.Size = new Size(658, 31);
            filterText.TabIndex = 7;
            filterText.TextChanged += ApplyFilter;
            // 
            // dropAction
            // 
            dropAction.Enabled = false;
            dropAction.Location = new Point(12, 287);
            dropAction.Name = "dropAction";
            dropAction.Size = new Size(658, 35);
            dropAction.TabIndex = 10;
            // [예제 변경] 버튼 글자와 연결 핸들러: DeleteSnack -> DeleteWorkout
            dropAction.Text = "선택 기록 삭제";
            dropAction.Click += DeleteWorkout;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(submitAction);
            groupBox1.Controls.Add(linkField);
            groupBox1.Controls.Add(descField);
            groupBox1.Controls.Add(titleField);
            groupBox1.Location = new Point(15, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 72);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // [예제 변경] 그룹 제목: 야식 추가 -> 운동 기록 추가
            groupBox1.Text = "운동 기록 추가";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 414);
            Controls.Add(groupBox1);
            Controls.Add(dropAction);
            Controls.Add(imageRenderer);
            Controls.Add(filterText);
            Controls.Add(mainContainer);
            Name = "Form1";
            // [예제 변경] 창 제목: 스트레스 풀 야식 -> 오운완 운동 기록장
            Text = "오운완 운동 기록장";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private GroupBox groupBox1;
        private TextBox titleField;
        private TextBox descField;
        private TextBox linkField;
        private Button submitAction;

        private ListBox mainContainer;
        private PictureBox imageRenderer;

        private TextBox filterText;
        private Button dropAction;
    }
}
