using System.ComponentModel.DataAnnotations;

// [예제 변경] 네임스페이스: G26W09WFSnackList -> G26HW01WorkoutLog (프로젝트 이름)
namespace G26HW01WorkoutLog;

// [예제 변경] record 이름: Snack(야식) -> Workout(운동 기록)
public record Workout(
    string Name,
    // [예제 변경] 두 번째 값: Reason(스트레스 원인) -> Note(세트·무게·시간 메모)
    string Note,
    string Image
) {
    [Key]
    public int Id { get;  init; }

    public override string ToString() => $"[{Name}] {Note}";
}
