// [예제 변경] 네임스페이스: G26W09WFSnackList -> G26HW01WorkoutLog
namespace G26HW01WorkoutLog;

public partial class Form1 : Form {
    // [예제 변경] 변수 이름: SnackStore -> WorkoutStore
    private Database WorkoutStore = new(); // new에 클래스 이름 생략 가능

    public Form1() {
        InitializeComponent();

        WorkoutStore.Database.EnsureCreated(); // 데이터베이스 없으면 자동 생성

        if (!WorkoutStore.Tuples.Any())
            // [예제 변경] AddInitSnack -> AddInitWorkout
            WorkoutStore.AddInitWorkout();

        ExecuteQuery();
    }

    private void ApplyFilter(object sender, EventArgs e) {
        ExecuteQuery();
    }

    private void ExecuteQuery() {
        mainContainer.Items.Clear();

        string keyword = filterText.Text.Trim();

        // [예제 변경] 검색 대상: Name, Reason -> Name, Note
        var filteredResult = WorkoutStore.Tuples
            .Where(item => item.Name.ToLower().Contains(keyword) ||
                    item.Note.ToLower().Contains(keyword))
            .ToList();

        foreach (var item in filteredResult)
            mainContainer.Items.Add(item);
    }

    private void ShowImage(object sender, EventArgs e) {
        // [예제 변경] 패턴 타입: Snack -> Workout
        if (mainContainer.SelectedItem is not Workout selected) {
            dropAction.Enabled = false;
            imageRenderer.Image = null;
            return;
        }

        dropAction.Enabled = true;

        if (string.IsNullOrEmpty(selected.Image)) {
            imageRenderer.Image = null;
            return;
        }

        imageRenderer.LoadAsync(selected.Image);
    }

    // [예제 변경] 이벤트 핸들러 이름: InsertSnack -> InsertWorkout
    private void InsertWorkout(object sender, EventArgs e) {
        string title = titleField.Text.Trim();
        // [예제 변경] 변수 이름: reason -> note
        string note = descField.Text.Trim();
        string image = linkField.Text.Trim();
        if (string.IsNullOrEmpty(image)) image = "";

        if (title.Length == 0 || note.Length == 0) {
            // [예제 변경] 안내 문구: 야식 이름과 원인 -> 운동 이름과 기록 메모
            MessageBox.Show("운동 이름과 기록 메모를 입력하세요.");
            return;
        }

        // [예제 변경] new Snack(...) -> new Workout(...)
        WorkoutStore.Tuples.Add(new Workout(title, note, image));
        WorkoutStore.SaveChanges();

        ExecuteQuery();

        titleField.Clear();
        descField.Clear();
        linkField.Clear();
    }

    // [예제 변경] 이벤트 핸들러 이름: DeleteSnack -> DeleteWorkout
    private void DeleteWorkout(object sender, EventArgs e) {
        // [예제 변경] 패턴 타입: Snack -> Workout
        if (mainContainer.SelectedItem is not Workout outcast) {
            dropAction.Enabled = false;
            return;
        }

        var result = MessageBox.Show(
                // [예제 변경] 확인 문구: 야식을 삭제할까요? -> 운동 기록을 삭제할까요?
                $"{outcast.Name}\n\n운동 기록을 삭제할까요?",
                "삭제 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

        if (result != DialogResult.Yes)
            return;

        WorkoutStore.Tuples.Remove(outcast);
        WorkoutStore.SaveChanges();

        ExecuteQuery();

        dropAction.Enabled = false;
    }
}
