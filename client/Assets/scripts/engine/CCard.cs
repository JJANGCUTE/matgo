using System;
using System.Collections;

// ī�� Ÿ��.
public enum PAE_TYPE : byte
{
    PEE,
    KWANG,
    TEE,
    YEOL
}


// ī�� �Ӽ�.
public enum CARD_STATUS : byte
{
	NONE,
	GODORI,			// ����
	TWO_PEE,		// ����
	CHEONG_DAN,		// û��
	HONG_DAN,		// ȫ��
	CHO_DAN,		// �ʴ�
	KOOKJIN			// ����
}

public class CCard
{
	// Ư�� ī�忡 ���� ������.
	public static readonly byte BEE_KWANG = 11;


	// 0 ~ 11 number.
	public byte number { get; private set; }
	
	// pae type.
    public PAE_TYPE pae_type { get; private set; }
	
	// 1,2,3,4 position.
	public byte position { get; private set; }

	public CARD_STATUS status { get; private set; }


	public CCard(byte number, PAE_TYPE pae_type, byte position)
	{
		this.number = number;
        this.pae_type = pae_type;
		this.position = position;
		this.status = CARD_STATUS.NONE;
	}


	public void set_card_status(CARD_STATUS status)
	{
		this.status = status;
	}


	public void change_pae_type(PAE_TYPE pae_type_to_change)
	{
		this.pae_type = pae_type_to_change;
	}


    public static bool is_bonus_card(byte number)
    {
        return number == 13;
    }


	public bool is_same(byte number, PAE_TYPE pae_type, byte position)
	{
		return this.number == number &&
			this.pae_type == pae_type &&
			this.position == position;
	}


	public bool is_same_number(byte number)
	{
		return this.number == number;
	}


	public bool is_same_status(CARD_STATUS status)
	{
		return this.status == status;
	}
}
