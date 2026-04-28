using UnityEngine;
using UnityEngine.Tilemaps;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] Tilemap coinTilemap;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Get the bounds of the player's collider
        Bounds playerBounds = collision.bounds;
        
        // Convert to cell coordinates
        Vector3Int minCell = coinTilemap.WorldToCell(playerBounds.min);
        Vector3Int maxCell = coinTilemap.WorldToCell(playerBounds.max);
        
        // Iterate through all cells the player overlaps
        for (int x = minCell.x; x <= maxCell.x; x++)
        {
            for (int y = minCell.y; y <= maxCell.y; y++)
            {
                Vector3Int cellPosition = new Vector3Int(x, y, 0);
                
                if (coinTilemap.HasTile(cellPosition))
                {
                    coinTilemap.SetTile(cellPosition, null);
                    
                    if (coinPickupSFX != null)
                    {
                        Vector3 tileWorldPos = coinTilemap.GetCellCenterWorld(cellPosition);
                        AudioSource.PlayClipAtPoint(coinPickupSFX, tileWorldPos);
                    }
                }
            }
        }
    }
}
