using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN meal_reservation AND meal_type
/// </summary>
public partial class MealReservationMealTypeRel
{
    public int MealReservationId { get; set; }

    public int MealTypeId { get; set; }

    public virtual MealReservation MealReservation { get; set; } = null!;

    public virtual MealType MealType { get; set; } = null!;
}
