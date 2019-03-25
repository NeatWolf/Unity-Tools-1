using UnityEngine;

public abstract class FuckingAngles {

	/// <summary>
	/// Returns a normalized Vector2 direction.
	/// </summary>
	/// <param name="angleInDeg">Angle in degrees.</param>
	public static Vector2 DirectionFromAngle(float angleInDeg) {
		return new Vector2(Mathf.Cos(angleInDeg * Mathf.Deg2Rad), Mathf.Sin(angleInDeg * Mathf.Deg2Rad));
	}

	/// <summary>
	/// Returns the signed angle of the vector direction.
	/// (Range of -180º to 180º)
	/// </summary>
	/// <param name="direction">The direction.</param>
	public static float SignedAngleBetweenV2(Vector2 direction) {
		return SignedAngleBetweenV2(Vector2.zero, direction);
	}

	/// <summary>
	/// Returns the signed angle between the two vector positions.
	/// (Range of -180º to 180º)
	/// </summary>
	/// <param name="a">The start position.</param>
	/// <param name="b">The end position.</param>
	public static float SignedAngleBetweenV2(Vector2 a, Vector2 b) {
		Vector2 diference = b - a;
		float sign = (b.y < a.y) ? -1.0f : 1.0f;
		return Vector2.Angle(Vector2.right, diference) * sign;
	}

	/// <summary>
	/// Converts an unsigned angle to a signed angle.
	/// </summary>
	/// <returns>The signed angle.</returns>
	/// <param name="angle">Angle.</param>
	public static float GetSignedAngle(float angle) {
		while (angle > 180)
			angle -= 360;
		while (angle < -180)
			angle += 360;

		return angle;
	}

	/// <summary>
	/// Converts an signed angle to an unsigned angle.
	/// </summary>
	/// <param name="signedAngle">Signed angle.</param>
	public static float GetNormalAngle(float signedAngle) {
		signedAngle = GetSignedAngle(signedAngle);
		if (signedAngle < 0)
			signedAngle += 360;
		return signedAngle;
	}

	/// <summary>
	/// Returns the angle of the vector direction.
	/// (Range of 0º to 359º)
	/// </summary>
	/// <param name="direction">The direction.</param>
	public static float AngleBetweenV2(Vector2 direction) {
		return Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
	}

	/// <summary>
	/// Returns the angle between two vector positions.
	/// (Range of 0º to 359º)
	/// </summary>
	/// <param name="a">The start position.</param>
	/// <param name="b">The end position.</param>
	public static float AngleBetweenV2(Vector2 a, Vector2 b) {
		Vector2 direction = b - a;
		return AngleBetweenV2(direction);
	}
}